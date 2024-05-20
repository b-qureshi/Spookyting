using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelHead : MonoBehaviour
{
    public bool canLook;
    public GameObject skelHead;
    public GameObject player;

    void Start()
    {
        canLook = false;
    }

    void OnMouseOver()
    {
        if (Input.GetButtonDown("Action"))
        {
            canLook = true;
        }
    }

    void Update()
    {
        if (canLook == true)
        {
            skelHead.transform.LookAt(player.transform.position);
        }
    }
}
