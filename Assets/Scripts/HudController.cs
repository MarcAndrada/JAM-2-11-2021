using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HudController : MonoBehaviour
{

    [SerializeField]
    Image W;
    [SerializeField]
    Image A;
    [SerializeField]
    Image S;
    [SerializeField]
    Image D;
    [SerializeField]
    Image Image1;
    [SerializeField]
    Image Image2;
    [SerializeField]
    Image Mouse;

    float alpha = 1;
    Color coloralpha;
    private float TimeToDestroy = 3;
    private float TimePassed;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        TimePassed += Time.deltaTime;

        if (TimeToDestroy <= TimePassed)
        {
            alpha -= 0.1f * Time.deltaTime;
            W.color = new Color(1, 1, 1, alpha);
            A.color = new Color(1,1,1, alpha);
            S.color = new Color(1, 1, 1, alpha);
            D.color = new Color(1, 1, 1, alpha);
            Image1.color = new Color(1, 1, 1, alpha);
            Image2.color = new Color(1, 1, 1, alpha);
            Mouse.color = new Color(1, 1, 1, alpha);


        }
    }
}
