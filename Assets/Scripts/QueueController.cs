using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueController : MonoBehaviour
{ 
    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    GameObject LastInQueue;

    private AudioSource audiosrc;

    // Start is called before the first frame update
    void Start()
    {
        LastInQueue = gameObject;
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewComrade(GameObject _newComrade) 
    {
        audiosrc.PlayOneShot(clip);
        ComradeController comradeCont;
        comradeCont = _newComrade.GetComponent<ComradeController>();
        comradeCont.WhoWillFollow(LastInQueue);
        //hacer funcion de decirle al camarada que tiene que seguir al ultimo de la cola

        LastInQueue = _newComrade;
    }
}
