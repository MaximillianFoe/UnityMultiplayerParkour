using System;
using System.Collections;
using UnityEngine;
using Photon.Bolt;
using Photon.Bolt.Matchmaking;
using Photon.Bolt.Utils;

public class PlayerMovement : Photon.Bolt.EntityBehaviour<IOyuncuDurumu>
{
    public override void Attached()
    {
        state.SetTransforms(state.Hareket, transform);
        state.Skor = 10;
    }
    public override void SimulateOwner()
    {
        var speed = 4f;
        var movement = Vector3.zero;
        if (Input.GetKey(KeyCode.A)){
            movement.x -= 1f;
        }
        if (Input.GetKey(KeyCode.D)){
            movement.x += 1f;
        }
        if (Input.GetKey(KeyCode.W)){
            movement.z += 1f;
        }
        if (Input.GetKey(KeyCode.S)){
            movement.z -= 1f;
        }
        if (movement != Vector3.zero){
            transform.position = transform.position + (movement.normalized * speed * BoltNetwork.FrameDeltaTime);
        }
    }
    public void OnCollisionEnter(Collision TrapCol){
        if (TrapCol.gameObject.tag == "TuzakTemas")
        {
            Debug.Log("Mahkum Tuzağa Değdi!");
            state.Skor = state.Skor - 1;
            Debug.Log("Skor:" + state.Skor);
            if(state.Skor <= 0){
            Debug.Log("Oyun Bitti!");
            BoltNetwork.LoadScene("GameOver");
            } 
        }
        if (TrapCol.gameObject.tag == "FinalLine")
        {
            Debug.Log("Mahkum Başarıyla Kaçtı!");
            BoltNetwork.LoadScene("GameWin");
        } 
    }  
    public void Update(){
        GetComponentInChildren<TextMesh>().text = "Skor:" + state.Skor;
    }
}
