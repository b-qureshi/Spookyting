using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public float distance;
    public float interactDistance;
    public GameObject objectPick;
    public GameObject pickUpHand;
    public static bool hasObject;
    public AudioSource pickSound;
    public static int keyAmount;

    void Start()
    {
        pickUpHand.SetActive(false);
        keyAmount = PlayerInventory.keyAmount;
        interactDistance = PlayerCasting.interactDistance;
    }

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= interactDistance)
        {
            pickUpHand.SetActive(true);
            
            if (Input.GetButtonDown("pick"))
            {
                hasObject = true;
                objectPick.SetActive(false);
                pickSound.Play();
    
                pickUpHand.SetActive(false);
                keyAmount += 1;
                PlayerInventory.keyAmount = keyAmount;
                Debug.Log(keyAmount);
            }
        }
        else
        {
            pickUpHand.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        pickUpHand.SetActive(false);
    }
}
