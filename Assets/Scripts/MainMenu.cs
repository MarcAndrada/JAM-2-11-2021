using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject optionMenu;
    [SerializeField]
    private AudioClip clip;

    private GameObject ManagersObj;
    private VolumeController sourceController;
    [SerializeField]
    private AudioSource audiosrc;

    // Start is called before the first frame update
    private void Start()
    {
        ManagersObj = GameObject.FindGameObjectWithTag("Managers");
        sourceController = ManagersObj.GetComponent<VolumeController>();
        audiosrc = sourceController.SFXAudioSource();
    }
    public void PlayGame ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        audiosrc.PlayOneShot(clip);
        SceneManager.LoadScene("Room");
        Time.timeScale = 1;
    }
    public void Options()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        audiosrc.PlayOneShot(clip);
        SceneManager.LoadScene("Options");
        
    }
    public void mainMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        audiosrc.PlayOneShot(clip);
        SceneManager.LoadScene("MainMenu");
    }
    public void Credits()
    {
        audiosrc.PlayOneShot(clip);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame ()
    {
        audiosrc.PlayOneShot(clip);
        Application.Quit();
    }
    public void PauseGame()
    {
        audiosrc.PlayOneShot(clip);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
        optionMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        audiosrc.PlayOneShot(clip);
        optionMenu.SetActive(false);// que la velocidad del juego regrese a 1
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //sound.SaveValues();
    }
}