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

    public TMP_Text TxtConnect, TxtFree, TxtReserved, TxtBalanceTime, TxtState, TxtBlockNumber, TxtBlockNumberTime, BtnTxtConnect;

    public Toggle OptBlockNumber, OptBalance;

    public Image ImgConnect, PgbBlockNumberFiller, PgbBalanceFiller, PgbStateFiller;

    private Task _connectTask;

    private bool _queryBlockNumberFlag, _queryBalanceFlag;

    private int BalanceFiller = 0;

    private NetworkManager Network => NetworkManager.Instance;

    // Start is called before the first frame update
    void Start()
    {
        Network.ExtrinsicStateUpdateEvent += OnExtrinsicStateUpdateEvent;
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
                OptBlockNumber.interactable = true;
            }
            else
            {
                BtnTxtConnect.text = "CONNECT";
                ImgConnect.color = new Color32(0xFF, 0x64, 0x64, 0xFF);
                TxtConnect.text = "..." + "\n" + "...";
                TxtBalanceTime.text = "... ms";
                OptBalance.interactable = false;
                OptBalance.isOn = false;
                TxtBlockNumberTime.text = "... ms";
                OptBlockNumber.interactable = false;
                OptBlockNumber.isOn = false;
            }
            _connectTask = null;
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

    public void OnChangedOptBlock(bool changed)
    {
        if (OptBlockNumber.isOn)
        {
            InvokeRepeating("QueryBlock", 0, 1f);
        }
        else
        {
            TxtBlockNumberTime.text = "... ms";
            CancelInvoke("QueryBlock");
        }
    }

    public async void QueryBlock()
    {
        if (!_queryBlockNumberFlag)
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            _queryBlockNumberFlag = true;
            stopWatch.Start();
            var blockNumber = await Network.Client.SystemStorage.Number(CancellationToken.None);
            stopWatch.Stop();
            TxtBlockNumber.text = blockNumber.Value.ToString();
            TxtBlockNumberTime.text = (float) stopWatch.ElapsedTicks / 10000 + " ms";
            _queryBlockNumberFlag = false;
        } 
    }

    public void OnChangedOptBalance(bool changed)
    {
        if (OptBalance.isOn)
        {
            BalanceFiller = 0;
            InvokeRepeating("QueryBalance", 0, 1);
        }
        else
        {
            TxtBalanceTime.text = "... ms";
            CancelInvoke("QueryBalance");
            PgbBalanceFiller.rectTransform.localScale = Vector3.one;
        }
    }

    public async void QueryBalance()
    {
        if (BalanceFiller % 7 == 0 && !_queryBalanceFlag)
        {
            var accountId32 = new AccountId32();
            accountId32.Create(Network.Alice.Bytes);

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            _queryBalanceFlag = true;
            stopWatch.Start();
            var account = await Network.Client.SystemStorage.Account(accountId32, CancellationToken.None);
            stopWatch.Stop();

            TxtFree.text = account.Data.Free.Value.ToString();
            TxtReserved.text = account.Data.Reserved.Value.ToString();

            TxtBalanceTime.text = (float)stopWatch.ElapsedTicks / 10000 + " ms";
            _queryBalanceFlag = false;

        }

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
        var subscription = Network.Client.Author.SubmitAndWatchExtrinsicAsync(Network.ActionExtrinsicUpdate, extrinsicMethod, Network.Alice, chargeAssetTx, 64, CancellationToken.None);
    }

    private void OnExtrinsicStateUpdateEvent(string subscriptionId, ExtrinsicStatus extrinsicStatus)
    {
        var state = "Unknown";
        var value = 0;
        switch (extrinsicStatus.ExtrinsicState)
        {
            case ExtrinsicState.None:
                if (extrinsicStatus.InBlock?.Value.Length > 0)
                {
                    state = "InBlock";
                    value = 5;
                }
                else if (extrinsicStatus.Finalized?.Value.Length > 0)
                {
                    state = "Finalized";
                    value = 6;
                }
                else
                {
                    state = "None";
                    value = 0;
                }
                break;

            case ExtrinsicState.Future:
                state = "Future";
                break;

            case ExtrinsicState.Ready:
                state = "Ready";
                value = 2;
                break;

            case ExtrinsicState.Dropped:
                state = "Dropped";
                value = 0;
                break;

            case ExtrinsicState.Invalid:
                state = "Invalid";
                value = 0;
                break;
        }

        UnityMainThreadDispatcher.DispatchAsync(() =>
        {
            TxtState.text = state;
            PgbStateFiller.rectTransform.localScale = new Vector3((float)value / 6, 1f, 1f);
        });
    }

}
