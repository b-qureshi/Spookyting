using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockedDoor : MonoBehaviour
{
    public float distance;
   
    public GameObject unlockText;
    public GameObject lockedText;
    public GameObject door;
    public AudioSource creakSound;
    public AudioSource lockSound;
    public AudioSource unlockSound;
    public GameObject pickUpHand;
    
    public int keysNeeded;
    public int keysHave;
    
    private bool showTextIsPlaying;
    public bool isLocked;
    private bool isClosed;

    void Start()
    {
        pickUpHand.SetActive(false);
        lockedText.SetActive(false);
        unlockText.SetActive(false);
        keysHave = PlayerInventory.keyAmount;
        isLocked = true;
        isClosed = true;
    }

    void Update()
    {
        distance = PlayerCasting.distanceFromTarget;
        keysHave = PlayerInventory.keyAmount;
    }

    void ChangeDoorState()
    {
        isClosed = !isClosed;
    }

    void OnMouseOver()
    {
        if (distance <= 3)
        {
            if (Input.GetButtonDown("Action"))
            {
                if (keysHave == keysNeeded || Input.GetButtonDown("debugMode"))
                {
                    if (isLocked)
                    {
                        isLocked = false;
                        StartCoroutine("ShowUnlockedMessage");
                    }
                    
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
                else
                {
                    StartCoroutine("ShowLockedMessage");
                    isLocked = true;
                }
            }
            else
            {
                if (showTextIsPlaying != true)
                {
                    pickUpHand.SetActive(true);
                }
            }
        }
        else
        {

            pickUpHand.SetActive(false);
        }
       
    }

    IEnumerator ShowLockedMessage()
    {
        lockSound.Play();
        showTextIsPlaying = true;
        pickUpHand.SetActive(false);
        lockedText.SetActive(true);
        yield return new WaitForSeconds(2);
        lockedText.SetActive(false);
        showTextIsPlaying = false;
    }

    IEnumerator ShowUnlockedMessage()
    {
        unlockSound.Play();
        showTextIsPlaying = true;
        pickUpHand.SetActive(false);
        unlockText.SetActive(true);
        yield return new WaitForSeconds(2);
        unlockText.SetActive(false);
        showTextIsPlaying = false;
    }


    private void OnMouseExit()
    {
        pickUpHand.SetActive(false);
    }
}