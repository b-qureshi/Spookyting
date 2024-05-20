using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSeq : MonoBehaviour
{
    public GameObject trigger;
    public GameObject box;
    public GameObject text;
    public GameObject trapDoor;
    public AudioSource creak;
    public AudioSource chaseMusic;
    public AudioSource scream;

    
    // Start is called before the first frame update
    void Start()
    {
        trigger.SetActive(true);
        text.SetActive(false);
        GetComponent<BoxCollider>().enabled = true;
    }

    void OnTriggerEnter()
    {
        trapDoor.GetComponent<Animation>().Play("TrapDoorBoi");
        creak.Play();
        StartCoroutine(ShowText());
        GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator ShowText()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        text.SetActive(false);
    }
}