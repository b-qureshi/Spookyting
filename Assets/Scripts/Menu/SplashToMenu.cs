﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("TakeToMenu");
    }

    IEnumerator TakeToMenu()
    {
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(1);
    }
}
