using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject options;
    public GameObject credits;
    
    void Start()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
        credits.SetActive(false);
    }
}
