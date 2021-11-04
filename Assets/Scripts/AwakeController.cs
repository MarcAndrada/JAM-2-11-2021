using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AwakeController : MonoBehaviour
{
    public GameObject SceneManager;
    public GameObject SoundManager;
    private int trueawake = 0;
    private void Awake()
    {
        if (trueawake == 0)
        {
            Instantiate(SceneManager);
            Instantiate(SoundManager);
            trueawake++;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
