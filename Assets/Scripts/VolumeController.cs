using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolumeController : MonoBehaviour
{
    public AudioClip MainMenu;
    public AudioClip Room;

    private AudioSource audiosouce;
    private float musicVolume;
    private Scene ActiveScene;
    private SoundManager sound;
    // Start is called before the first frame update
    void Start()
    {
        audiosouce = GetComponent<AudioSource>();
        sound = GetComponentInParent<SoundManager>();
        musicVolume = sound.GetMusicVol();
    }

    // Update is called once per frame
    void Update()
    {
        ActiveScene = SceneManager.GetActiveScene();

        audiosouce.volume = musicVolume;

        if (!audiosouce.isPlaying)
        {
            audiosouce.clip = null;
        }
        else if (ActiveScene.name == "Room" || ActiveScene.name == "Tutorial")
        {
            if (audiosouce.clip != Room)
            {
                audiosouce.Stop();
                audiosouce.PlayOneShot(Room);
                audiosouce.clip = Room;
            }
            /*audiosouce.clip = Level1;
            audiosouce.playOnAwake = Level1;*/
        }
    }
    public void SetVolume(float vol)
    {
        if (sound != null)
        {
            musicVolume = vol;
        }
        
    }
}
