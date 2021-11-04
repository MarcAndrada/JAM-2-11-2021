using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudController : MonoBehaviour
{

    [SerializeField]
    GameObject W;
    [SerializeField]
    GameObject A;
    [SerializeField]
    GameObject S;
    [SerializeField]
    GameObject D;
    [SerializeField]
    GameObject Image1;
    [SerializeField]
    GameObject Image2;


    private float TimeToDestroy = 5;
    private float TimePassed;

    // Update is called once per frame
    void Update()
    {
        TimePassed += Time.deltaTime;

        if (TimeToDestroy <= TimePassed)
        {
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(false);
            Image1.SetActive(false);
            Image2.SetActive(false);


        }
    }
}
