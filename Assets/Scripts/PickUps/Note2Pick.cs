using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note2Pick : MonoBehaviour
{
    public float distance;
    public GameObject actionText;
    public GameObject noteObject;
    public GameObject noteRead;
    public GameObject extraCross;
    public AudioSource noteSound;
    public bool reading;

    void Start()
    {
        actionText.SetActive(false);
        extraCross.SetActive(false);
    }

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 2 && !reading)
        {
            actionText.SetActive(true);
            extraCross.SetActive(true);
        }
        else
        {
            actionText.SetActive(false);
            extraCross.SetActive(false);
        }

        if (Input.GetButtonDown("pick") && distance <= 2 && !reading)
        {
            reading = true;
            noteRead.SetActive(true);
            extraCross.SetActive(false);
            noteSound.Play();
        }
        else if (Input.GetButtonDown("pick") && distance <= 2 && reading)
        {
            reading = false;
            noteRead.SetActive(false);
            noteSound.Play();
        }
    }

    private void OnMouseExit()
    {
        actionText.SetActive(false);
        extraCross.SetActive(false);
    }
}