using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public AudioSource endMusic;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ending());
    }

    IEnumerator ending()
    {
        text.GetComponent<Text>().text = "Guess he didn't press space";
        yield return new WaitForSeconds(3.5f);
        endMusic.Play();
        text.GetComponent<Text>().text = "Created by\nBilal Qureshi";
        yield return new WaitForSeconds(4.5f);
        text.GetComponent<Text>().text = "Code and (some) Effects\ncreated by Bilal Qureshi";
        yield return new WaitForSeconds(3.5f);
        text.GetComponent<Text>().text = "Assets from Jimmy Vegas (bigup)\nand the Unity Asset store";
        yield return new WaitForSeconds(3.5f);
        text.GetComponent<Text>().text = "Inspired by \"Death Trips\" \nby Alberto Navarro";
        yield return new WaitForSeconds(3.5f);
        text.GetComponent<Text>().text = "Thanks for playing!";
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene(1);
        
    }

}
