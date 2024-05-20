using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Note : MonoBehaviour
{
    public float interactDistance;
    public float distance;
    public GameObject actionHand;
    public GameObject noteObject;
    public GameObject noteImage;
    public GameObject darkScreen;
    public GameObject player;
    public GameObject closeButton;
    public AudioSource noteSound;
    public bool reading;

    void Start()
    {
        interactDistance = PlayerCasting.interactDistance;
        actionHand.SetActive(false);
        reading = false;
    }

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= interactDistance && !reading)
        {
            actionHand.SetActive(true);

            if (Input.GetButtonDown("pick"))
            {
                actionHand.SetActive(false);
                ReadNote();
            }
        }
        else
        {
            actionHand.SetActive(false);
        }
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
        actionHand.SetActive(false);
    }

    private void OnMouseExit()
    {
        actionHand.SetActive(false);
    }
}
