using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EndSequence");
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
