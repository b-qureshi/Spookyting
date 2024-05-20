using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellClose : MonoBehaviour
{
    public float distance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject door;
    public AudioSource creakSound;
    public GameObject extraCross;
    public static bool isClosed;

    void Start()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
        extraCross.SetActive(false);
        isClosed = false;
    }

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (distance <= 2)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            extraCross.SetActive(true);
        }
        else
        {
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            extraCross.SetActive(false);
        }

        if (Input.GetButtonDown("Action") && distance <= 2 && isClosed == false)
        {
            this.GetComponent<BoxCollider>().enabled = true;
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
            door.GetComponent<Animation>().Play("FirstDoorCloseAnim");
            creakSound.Play();
            isClosed = true;
        }
    }

    private void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
        extraCross.SetActive(false);
    }
}