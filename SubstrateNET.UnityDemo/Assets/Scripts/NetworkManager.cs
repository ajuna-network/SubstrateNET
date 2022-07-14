using Ajuna.NetApi;
using Ajuna.NetApi.Model.Rpc;
using Ajuna.NetApi.Model.Types;
using Schnorrkel.Keys;
using SubstrateNET.NetApi.Generated;
using SubstrateNET.RestClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public delegate void ExtrinsicStateUpdate(string subscriptionId, ExtrinsicStatus extrinsicUpdate);

public class NetworkManager : MonoBehaviour
{
    public static NetworkManager Instance;

    public MiniSecret MiniSecretAlice => new MiniSecret(Utils.HexToByteArray("0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a"), ExpandMode.Ed25519);
    public Account Alice => Account.Build(KeyType.Sr25519, MiniSecretAlice.ExpandToSecret().ToBytes(), MiniSecretAlice.GetPair().Public.Key);
    public MiniSecret MiniSecretBob => new MiniSecret(Utils.HexToByteArray("0x398f0c28f98885e046333d4a41c19cee4c37368a9832c6502f6cfd182e2aef89"), ExpandMode.Ed25519);
    public Account Bob => Account.Build(KeyType.Sr25519, MiniSecretBob.ExpandToSecret().ToBytes(), MiniSecretBob.GetPair().Public.Key);


    [SerializeField]
    public string WalletName = "wallet";

    [SerializeField]
    public string NodeUrl = "ws://127.0.0.1:9944";

    [SerializeField]
    public string RestUrl = "http://127.0.0.1:61752";

    [SerializeField]
    public string SubscriptionUrl = "http://127.0.0.1:61752/ws";

    public event ExtrinsicStateUpdate ExtrinsicStateUpdateEvent;

    private SubstrateClientExt _client;
    public SubstrateClientExt Client => _client;
    private HttpClient _httpClient;
    private BaseSubscriptionClient _subscriptionClient;
    private Client _serviceClient;

    void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        _client = new SubstrateClientExt(new Uri(NodeUrl));

        _subscriptionClient = new BaseSubscriptionClient(new ClientWebSocket());

        var httpClient = new HttpClient()
        {
            BaseAddress = new Uri(RestUrl)
        };
        _serviceClient = new Client(httpClient, _subscriptionClient);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Simple extrinsic tester
    /// </summary>
    /// <param name="subscriptionId"></param>
    /// <param name="extrinsicUpdate"></param>
    public void ActionExtrinsicUpdate(string subscriptionId, ExtrinsicStatus extrinsicUpdate)
    {
        ExtrinsicStateUpdateEvent?.Invoke(subscriptionId, extrinsicUpdate);
    }
}
