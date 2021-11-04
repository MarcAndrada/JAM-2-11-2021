using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private SoundManager soundManager;
    // Start is called before the first frame update
    private void Start()
    {
        soundManager = SoundManager.FindObjectOfType<SoundManager>();
    }
    public void PlayGame ()
    {
        SceneManager.LoadScene("Room");
        soundManager.Reload();
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
        soundManager.Reload();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        soundManager.Reload();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        soundManager.Reload();
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
}