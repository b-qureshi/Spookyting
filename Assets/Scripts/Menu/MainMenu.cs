using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject loadText;
    public GameObject fadeOut;
    public AudioSource buttonClick;

    public void PlayButton()
    {
        StartCoroutine("NewGameStart");
    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3.5f);
        loadText.SetActive(true);
        loadText.GetComponent<Text>().text = "Use headphones for the best experience";
        yield return new WaitForSeconds(1.5f);
        loadText.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(3);
        loadText.GetComponent<Text>().text = "Loading...";
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    
}
