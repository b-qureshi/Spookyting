using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSeq : MonoBehaviour
{
    public GameObject subtitles;
    public GameObject black;
    public GameObject zombie;
    public AudioSource bang;
    public AudioSource pain;

    void Start()
    {
        zombie.SetActive(false);
        StartCoroutine(SequenceBegin());
    }

    IEnumerator SequenceBegin()
    {
        subtitles.GetComponent<Text>().text = "Is this the place?";
        yield return new WaitForSeconds(0.82f);
        subtitles.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.95f);
        subtitles.GetComponent<Text>().text = "Looks like I'm the first one here.";
        yield return new WaitForSeconds(1.04f);
        subtitles.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1.016f);
        subtitles.GetComponent<Text>().text = "I should probably check if there is anyone inside";
        yield return new WaitForSeconds(1.732f);
        subtitles.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2.732f);
        subtitles.GetComponent<Text>().text = "Hey there, anyone home?";
        yield return new WaitForSeconds(1.433f);
        subtitles.GetComponent<Text>().text = "";
        bang.Play();
        yield return new WaitForSeconds(2.024f);
        subtitles.GetComponent<Text>().text = "What was that?";
        yield return new WaitForSeconds(1.341f);
        subtitles.GetComponent<Text>().text = "Whoever that is, it's not funny!";
        yield return new WaitForSeconds(1.383f);
        subtitles.GetComponent<Text>().text = "";
        zombie.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        bang.Play();
        black.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        pain.Play();
        SceneManager.LoadScene(3);

    }
}
