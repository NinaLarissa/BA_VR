using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    
    public CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Playing Footsteps-Sound only when CC is moving
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 0.8 && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.8f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().Play();
        }
        if (cc.isGrounded == true && cc.velocity.magnitude == 0f && GetComponent<AudioSource>().isPlaying == true)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}