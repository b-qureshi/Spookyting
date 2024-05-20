using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class GameOpening : MonoBehaviour
{
    public GameObject player;
    public GameObject fadeScreenIn;
    public GameObject textBox;
    public AudioSource introDialogue;
    public AudioSource music;

    void Start()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine (ScenePlayer ());
    }

    IEnumerator ScenePlayer()
    {
        introDialogue.Play();
        yield return new WaitForSeconds(2.0f);
        fadeScreenIn.SetActive(false);
        textBox.GetComponent<Text> ().text = "Where am I? I need to get out of here...";
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "";
        player.GetComponent<FirstPersonController>().enabled = true;
        music.Play();
    }
}

  
