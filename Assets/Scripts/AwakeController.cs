using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AwakeController : MonoBehaviour
{
    public GameObject SceneManager;
    private int trueawake = 0;
    private void Awake()
    {
        if (trueawake == 0)
        {
            Instantiate(SceneManager);
            trueawake++;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
