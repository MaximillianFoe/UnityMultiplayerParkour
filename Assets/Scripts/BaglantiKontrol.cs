using System;
using System.Collections;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;
using UdpKit;
using UdpKit.Platform;
using UdpKit.Platform.Photon;
using UnityEngine;

public class BaglantiKontrol : Photon.Bolt.GlobalEventListener
{
    // bool AllPlayersAreHere;
    public GameObject playerPrefab;
    // public GameObject TuzakBir;
    // public GameObject TuzakIki;
    // public GameObject TuzakUc;
    public override void SceneLoadLocalDone(string scene, IProtocolToken token)
    {
        var spawnPos = new Vector3(-15, 2, 25);
        // var TuzakBP = new Vector3(-8, 1, 57);
        // var TuzakIP = new Vector3(8, 1, 57);
        // var TuzakUP = new Vector3(0, 1, 57);
        BoltNetwork.Instantiate(playerPrefab, spawnPos, Quaternion.identity);
        // BoltNetwork.Instantiate(TuzakBir, TuzakBP, Quaternion.identity);
        // BoltNetwork.Instantiate(TuzakIki, TuzakIP, Quaternion.identity);
        // BoltNetwork.Instantiate(TuzakUc, TuzakUP, Quaternion.identity);
        // if (BoltMatchmaking.CurrentSession.ConnectionsCurrent == 2){
            // AllPlayersAreHere = true;
        // } 
    }
    // public void Update()
    // {
        // if(AllPlayersAreHere == true){
            // var spawnPos = new Vector3(-14, 1, 28);
            // BoltNetwork.Instantiate(playerPrefab,spawnPos,Quaternion.identity);
            // AllPlayersAreHere = false;
        // }
    // }
}
