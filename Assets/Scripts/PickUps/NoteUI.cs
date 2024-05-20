using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class NoteUI : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject darkScreen;
    public GameObject player;

    public AudioSource noteSound;
    public GameObject noteImage;

    void Start()
    {
        noteImage.SetActive(false);
    }

    public void ReadNote()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        player.GetComponent<FirstPersonController>().enabled = false;

        noteImage.SetActive(true);
        closeButton.SetActive(true);
        darkScreen.SetActive(true);
        noteSound.Play();
    }

    public void CloseNote()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player.GetComponent<FirstPersonController>().enabled = true;

        noteImage.SetActive(false);
        darkScreen.SetActive(false);
        noteSound.Play();
    }

}
