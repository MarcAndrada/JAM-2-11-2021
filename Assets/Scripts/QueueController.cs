using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueController : MonoBehaviour
{

    [SerializeField]
    GameObject LastInQueue;
    // Start is called before the first frame update
    void Start()
    {
        LastInQueue = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewComrade(GameObject _newComrade) 
    {
        ComradeController comradeCont;
        comradeCont = _newComrade.GetComponent<ComradeController>();
        comradeCont.WhoWillFollow(LastInQueue);
        //hacer funcion de decirle al camarada que tiene que seguir al ultimo de la cola

        LastInQueue = _newComrade;
    }
}
