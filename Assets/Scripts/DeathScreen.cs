using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject loadText;
    public GameObject deathScreen;

    void Start()
    {
        loadText.SetActive(false);
        deathScreen.SetActive(true);
    }
    
    public void tryAgain()
    {
        deathScreen.SetActive(false);
        loadText.SetActive(true);
        SceneManager.LoadScene(2);
    }

    public void menu()
    {
        deathScreen.SetActive(false);
        loadText.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
