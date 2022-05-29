using System;
using System.Collections;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;
using UdpKit;
using UdpKit.Platform;
using UdpKit.Platform.Photon;
using UnityEngine;

public class BoltHandler : Photon.Bolt.GlobalEventListener
{
    public void ClickedStartServer()
    {
        BoltLauncher.StartServer();
    }

    public void ClickedStartClient()
    {
        BoltLauncher.StartClient();
    }

    public override void BoltStartDone()
    {
            BoltMatchmaking.CreateSession(sessionID: "Parkour", sceneToLoad: "Game");
    }

    public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
    {
        foreach (var session in sessionList)
        {
            UdpSession photonSession = session.Value as UdpSession;
            if(photonSession.Source == UdpSessionSource.Photon){
                BoltMatchmaking.JoinSession(photonSession);
            }
        }
    }

}
