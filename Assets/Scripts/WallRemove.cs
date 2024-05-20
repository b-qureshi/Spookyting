using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRemove : MonoBehaviour
{
    public GameObject wall;

    void Start()
    {
        wall.SetActive(true);
    }

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        wall.SetActive(false);
    }
}
