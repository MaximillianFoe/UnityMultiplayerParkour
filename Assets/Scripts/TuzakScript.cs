using System;
using System.Collections;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;
using UdpKit;
using UdpKit.Platform;
using UdpKit.Platform.Photon;
using UnityEngine;

public class TuzakScript : Photon.Bolt.EntityBehaviour<ITuzakDurumu>
{
    public override void Attached()
    {
    state.SetTransforms(state.Transform, transform);
    state.SetAnimator(GetComponent<Animator>());
    }
    void Update()
    {
    state.Animator.Play("TuzakState");       
    }
}
