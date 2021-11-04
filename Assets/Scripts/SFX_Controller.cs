using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Controller : MonoBehaviour
{
    private GameObject player;
    private AudioSource playerS;

    private GameObject[] Aliados;
    private AudioSource AliadosD;

    private SoundManager sound;
    private float Volume = 0.1f;
        private void Start()
    {
        sound = GetComponent<SoundManager>();
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {   
            playerS = player.GetComponent<AudioSource>();
        }
        Volume = sound.GetSFXVol();

    }
    void Update()
    {
        
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                playerS = player.GetComponent<AudioSource>();
            }
        }
               
        Aliados = GameObject.FindGameObjectsWithTag("Aliados");

        for (int i = 0; i < Aliados.Length; i++)
        {
            AliadosD = Aliados[i].GetComponent<AudioSource>();
            if (AliadosD != null)
            {   
                AliadosD.volume = Volume;
            }
        }
        
        if (player != null)
        {
            playerS.volume = Volume;
        }
    }

    public void SetVolume(float vol)
    {
        if (sound != null)
        {
            Volume = vol;
        }
    }
}
