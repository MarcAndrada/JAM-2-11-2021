using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame ()
    {
        SceneManager.LoadScene("Room");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}

