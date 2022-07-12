using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Rpc;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.FrameSystem;
using SubstrateNET.NetApi.Generated.Model.PalletBalances;
using SubstrateNET.NetApi.Generated.Model.SpCore;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public TMP_Text TxtConnect, TxtFree, TxtReserved, BtnTxtConnect;

    public Toggle OptBalance;

    public Image ImgConnect, PgbBalanceFiller;

    private Task _connectTask;
    private Task<AccountInfo> _queryBalancesTask;

    private int BalanceFiller = 0;

    private NetworkManager Network => NetworkManager.Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_connectTask != null && _connectTask.IsCompleted)
        {
            if (Network.Client.IsConnected)
            {
                BtnTxtConnect.text = "CLOSE";
                ImgConnect.color = new Color32(0x64, 0xFF, 0x64, 0xFF);
                TxtConnect.text = Network.Client.RuntimeVersion.SpecName + "/"
                                + Network.Client.RuntimeVersion.ImplName + "\n"
                                + Network.Client.RuntimeVersion.AuthoringVersion + "/"
                                + Network.Client.RuntimeVersion.SpecVersion + "/"
                                + Network.Client.RuntimeVersion.ImplVersion;
                OptBalance.interactable = true;
            }
            else
            {
                BtnTxtConnect.text = "CONNECT";
                ImgConnect.color = new Color32(0xFF, 0x64, 0x64, 0xFF);
                TxtConnect.text = "..." + "\n" + "...";
                OptBalance.interactable = false;
            }
            _connectTask = null;
        }

        if (_queryBalancesTask != null && _queryBalancesTask.IsCompleted)
        {
            if (_queryBalancesTask.Result != null)
            {
                TxtFree.text = _queryBalancesTask.Result.Data.Free.Value.ToString();
                TxtReserved.text = _queryBalancesTask.Result.Data.Reserved.Value.ToString();
            }
            _queryBalancesTask = null;
        }
    }

    public void OnClickBtnConnect()
    {
        if (_connectTask != null)
        {
            Debug.Log("Uncomplet connectTask.");
            return;
        }

        if (Network.Client.IsConnected)
        {
            _connectTask = Network.Client.CloseAsync();
            CancelInvoke(); // cancel all invokes
        }
        else
        {
            _connectTask = Network.Client.ConnectAsync();
        }
    }
    public void OnChangedOptBalance(bool changed)
    {
        if (changed)
        {
            BalanceFiller = 0;
            InvokeRepeating("QueryBalance", 0, 1);
        }
        else
        {
            CancelInvoke("QueryBalance");
            PgbBalanceFiller.rectTransform.localScale = Vector3.one;
        }
    }

    public void QueryBalance()
    {
        if (BalanceFiller % 7 == 0)
        {
            Debug.Log("QueryBalance");
            var accountId32 = new AccountId32();
            accountId32.Create(Network.Alice.Bytes);
            _queryBalancesTask = Network.Client.SystemStorage.Account(accountId32, CancellationToken.None);
        }

        //PgbBalanceFiller.fillAmount = (float) BalanceFiller / 6;
        PgbBalanceFiller.rectTransform.localScale = new Vector3((float)BalanceFiller / 6, 1f, 1f);

        BalanceFiller++;
        BalanceFiller %= 7;
    }

    public void OnClickBtnFaucet()
    {
        var accountId32 = new AccountId32();
        accountId32.Create(Network.Bob.Bytes);

        var multiAddressBob = new EnumMultiAddress();
        multiAddressBob.Create(MultiAddress.Id, accountId32);

        var amount = new BaseCom<U128>();
        amount.Create(100000);

        var chargeAssetTx = new ChargeAssetTxPayment(0,0);

        var extrinsicMethod = BalancesCalls.Transfer(multiAddressBob, amount);
        var subscription = Network.Client.Author.SubmitAndWatchExtrinsicAsync(ActionExtrinsicUpdate, extrinsicMethod, Network.Alice, chargeAssetTx, 64, CancellationToken.None);
    }

    /// <summary>
    /// Simple extrinsic tester
    /// </summary>
    /// <param name="subscriptionId"></param>
    /// <param name="extrinsicUpdate"></param>
    private void ActionExtrinsicUpdate(string subscriptionId, ExtrinsicStatus extrinsicUpdate)
    {
        switch (extrinsicUpdate.ExtrinsicState)
        {
            case ExtrinsicState.None:
                if (extrinsicUpdate.InBlock?.Value.Length > 0)
                {
                    Debug.Log($"{subscriptionId}: InBlock {extrinsicUpdate.InBlock.Value}");
                }
                else if (extrinsicUpdate.Finalized?.Value.Length > 0)
                {
                    Debug.Log($"{subscriptionId}: Finalized {extrinsicUpdate.Finalized.Value}");
                }
                break;
            case ExtrinsicState.Future:
                break;
            case ExtrinsicState.Ready:
                break;
            case ExtrinsicState.Dropped:
                break;
            case ExtrinsicState.Invalid:
                break;
            default:
                break;
        }
    }
}
