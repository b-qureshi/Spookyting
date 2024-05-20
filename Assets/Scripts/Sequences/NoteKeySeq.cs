using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class NoteKeySeq : MonoBehaviour
{
    public GameObject player;
    public GameObject textBox;
    public AudioSource dialogue;

    void OnTriggerEnter()
    {
        player.GetComponent<FirstPersonController>().enabled = false;
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        textBox.SetActive(true);
        textBox.GetComponent<Text>().text = "There seems to be a note... and a key...";
        dialogue.Play();
        yield return new WaitForSeconds(4f);
        player.GetComponent<FirstPersonController>().enabled = true;
        textBox.GetComponent<Text>().text = "";
        textBox.SetActive(false);
    }
}
