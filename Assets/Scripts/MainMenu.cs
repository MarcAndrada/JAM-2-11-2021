using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject optionMenu;

    private AudioSource audiosrc;
    public AudioClip clip;

    private SoundManager soundManager;
    // Start is called before the first frame update
    private void Start()
    {
        soundManager = gameObject.GetComponent<SoundManager>();

        audiosrc = GetComponent<AudioSource>();
    }
    public void PlayGame ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Room");
        soundManager = gameObject.GetComponent<SoundManager>();
        soundManager.Reload();
        audiosrc.PlayOneShot(clip);
    }
    public void Options()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("Options");
        soundManager = gameObject.GetComponent<SoundManager>();
        soundManager.Reload();
        audiosrc.PlayOneShot(clip);
    }
    public void mainMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("MainMenu");
        soundManager = gameObject.GetComponent<SoundManager>();
        soundManager.Reload();
        audiosrc.PlayOneShot(clip);
    }
    public void Credits()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("Credits");
        soundManager = gameObject.GetComponent<SoundManager>();
        soundManager.Reload();
        audiosrc.PlayOneShot(clip);
    }
    public void QuitGame ()
    {
        audiosrc.PlayOneShot(clip);
        Application.Quit();
    }
    public void PauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
        optionMenu.SetActive(true);
        soundManager = gameObject.GetComponent<SoundManager>();
        soundManager.Reload();
    }

    public void ResumeGame()
    {
        audiosrc.PlayOneShot(clip);
        Time.timeScale = 1;
        optionMenu.SetActive(false);// que la velocidad del juego regrese a 1
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //sound.SaveValues();
    }
}