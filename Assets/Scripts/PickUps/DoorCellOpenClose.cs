using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpenClose : MonoBehaviour
{
    public float distance;
    public GameObject door;
    public AudioSource creakSound;
    public GameObject pickUpHand;
    public bool isClosed;

    void Start()
    {
        pickUpHand.SetActive(false);
        isClosed = true;
    }

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void ChangeDoorState()
    {
        isClosed = !isClosed;
    }

    void OnMouseOver()
    {
        if (distance <= 3)
        {
            pickUpHand.SetActive(true);
        }
        else
        {

            pickUpHand.SetActive(false);
        }

        if (Input.GetButtonDown("Action") && distance <= 3)
        {
            if (isClosed)
            {
    
                door.GetComponent<Animation>().Play("DoorOpen");
                creakSound.Play();
                ChangeDoorState();
            }
            else
            {
    
                door.GetComponent<Animation>().Play("DoorClose");
                creakSound.Play();
                ChangeDoorState();
            }
        }
    }

    private void OnMouseExit()
    {
        pickUpHand.SetActive(false);
    }
}
