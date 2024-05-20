using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelJumpScare : MonoBehaviour
{
    public GameObject skeleton;
    public AudioSource jumpscare;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        skeleton.GetComponent<Animation>().Play("SkelJumpscare");
        jumpscare.Play();
    }
}
