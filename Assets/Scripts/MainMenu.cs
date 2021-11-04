using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject optionMenu;

    private SoundManager soundManager;
    // Start is called before the first frame update
    private void Start()
    {
        soundManager = SoundManager.FindObjectOfType<SoundManager>();
    }
    public void PlayGame ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Room");
        soundManager.Reload();
    }
    public void Options()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("Options");
        soundManager.Reload();
    }
    public void mainMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("MainMenu");
        soundManager.Reload();
    }
    public void Credits()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("Credits");
        soundManager.Reload();
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
        optionMenu.SetActive(true);
        soundManager.Reload();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        optionMenu.SetActive(false);// que la velocidad del juego regrese a 1
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //sound.SaveValues();
    }
}