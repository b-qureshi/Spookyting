using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckFall : MonoBehaviour
{
    public GameObject zombie;
    public AudioSource chaseMusic;
    public AudioSource scream;

    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>().enabled = true;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.name == "Zombie")
        {
            zombie.GetComponent<Animator>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            chaseMusic.Pause();
            scream.Play();
            yield return new WaitForSeconds(5.0f);
            scream.Pause();
            SceneManager.LoadScene(4);
        }
        
        if (other.name == "FPSController")
        {
            SceneManager.LoadScene(5);
        }
    }
}