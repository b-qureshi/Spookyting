using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningSeq : MonoBehaviour
{
    public GameObject trigger;
    public GameObject zombie;
    public GameObject box;
    public GameObject text;
    public AudioSource roar;
    public AudioSource chaseMusic;
    public AudioSource ambienceMusic;
    public float speed = 6f;

    
    // Start is called before the first frame update
    void Start()
    {
        trigger.SetActive(true);
        zombie.SetActive(false);
        text.SetActive(false);
        GetComponent<BoxCollider>().enabled = true;
    }

    void Update()
    {
        if (zombie.activeSelf)
        {
            float step = speed * Time.deltaTime;
            zombie.transform.position = Vector3.MoveTowards(zombie.transform.position, box.transform.position, step);
        }
    }

    void OnTriggerEnter()
    {
        ambienceMusic.Pause();
        zombie.SetActive(true);
        roar.Play();
        chaseMusic.Play();
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