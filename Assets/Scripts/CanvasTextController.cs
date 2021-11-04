using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTextController : MonoBehaviour
{
    [SerializeField]
    GameObject TextCanvas;
    // Start is called before the first frame update
    public void DesapearNumber()
    {
        TextCanvas.SetActive(false);
    }

    public void ActivateNumber()
    {
        TextCanvas.SetActive(true);
    }
}
