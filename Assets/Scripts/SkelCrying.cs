using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelCrying : MonoBehaviour
{
    public GameObject skeleton;

    void OnMouseOver()
    {
        if(Input.GetButtonDown("pick"))
        {
            skeleton.SetActive(false);
        }
    }
}
