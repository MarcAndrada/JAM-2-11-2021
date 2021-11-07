using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeController : MonoBehaviour
{
    [SerializeField]
    public AudioClip MainMenu;
    [SerializeField]
    public AudioClip Room;

    [SerializeField]
    private AudioSource MusicAudiosouce;
    [SerializeField]
    private AudioSource AudioSourceSFX;
    private Scene ActiveScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ActiveScene = SceneManager.GetActiveScene();

        /*if (!MusicAudiosouce.isPlaying)
        {
            MusicAudiosouce.clip = null;
        }*/
         if (ActiveScene.name == "Room" || ActiveScene.name == "MainMenu")
        {
            if (MusicAudiosouce.clip != Room)
            {
                MusicAudiosouce.Stop();
                MusicAudiosouce.PlayOneShot(Room);
                MusicAudiosouce.clip = Room;
            }
            /*audiosouce.clip = Level1;
            audiosouce.playOnAwake = Level1;*/
        }
    }

    public AudioSource SFXAudioSource()
    {
        return AudioSourceSFX;
    }
}
