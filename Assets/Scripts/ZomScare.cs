using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomScare : MonoBehaviour
{
    public GameObject trigger;
    public GameObject zombie;
    public GameObject box;
    public AudioSource grunt;
    public AudioSource effect;
    public float speed = 0.02f;
    
    // Start is called before the first frame update
    void Start()
    {
        trigger.SetActive(true);
        zombie.SetActive(false);
        GetComponent<BoxCollider>().enabled = true;
    }

    void Update()
    {
        if (zombie.activeSelf)
        {
            float step = speed * Time.deltaTime;
            zombie.transform.position = Vector3.MoveTowards(zombie.transform.position, box.transform.position, step);
            if (zombie.transform.position == box.transform.position)
            {
                zombie.SetActive(false);
                box.SetActive(false);
            }
        }
    }

    void OnTriggerEnter()
    {
        zombie.SetActive(true);
        grunt.Play();
        effect.Play();
        GetComponent<BoxCollider>().enabled = false;
    }
}