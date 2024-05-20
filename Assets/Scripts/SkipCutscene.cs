using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkipCutscene : MonoBehaviour
{
    public Image fillImage;
    public GameObject showText;
    public AudioSource dialogue;
    public AudioSource music;
    public float activeSpeed = .5f;
    float cooldownSpeed = .6f;
    bool functionTriggered = false;

    void Start()
    {
        showText.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        fillImage.fillAmount += ((Input.GetKey("escape") && !functionTriggered) ? activeSpeed : -cooldownSpeed) * Time.deltaTime;
      
      if (!functionTriggered && fillImage.fillAmount == 1)
        {
            functionTriggered = true;
            dialogue.Pause();
            music.Pause();
            showText.SetActive(true);
            SceneManager.LoadScene(3);
        }
    }
}
