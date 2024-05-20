using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAppearJumpScare : MonoBehaviour
{
    public GameObject zombie;
    public AudioSource jumpscare;

    public void Start()
    {
        zombie.SetActive(false);
    }

    void OnTriggerEnter()
    {
        StartCoroutine("JumpScare");
       
    }

    IEnumerator JumpScare()
    {
        GetComponent<BoxCollider>().enabled = false;
        zombie.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        jumpscare.Play();
        yield return new WaitForSeconds(0.5f);
        zombie.SetActive(false);
    }
}
