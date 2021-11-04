using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;


public class NumberController : MonoBehaviour
{

    [SerializeField]
    private GameObject particulas;
    [SerializeField]
    private InteractuableObjectController anim;   
    [SerializeField]
    private PlayerInteractController companionCount;
    [SerializeField]
    private GameObject player;
    private TextMeshPro textMesh;

    private int requiredCompanion;
    private int playerCompanion;

    // Start is called before the first frame update
    void Start()
    {
        companionCount = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteractController>();
        transform.position = particulas.transform.position;
        textMesh = gameObject.GetComponent<TextMeshPro>();
        requiredCompanion = anim.GetRequiredCompanions();
        playerCompanion = companionCount.GetCompanions();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerCompanion < requiredCompanion) {
            textMesh.text = requiredCompanion.ToString();
        }
        else
        {
            textMesh.text = "E";
        }
        transform.LookAt(player.transform.position);
        transform.Rotate(new Vector3(0,-1,0),180);
    }

    public void DesapearNumber() 
    {
        textMesh.enabled = false;
    }

    public void ActivateNumber()
    {
        textMesh.enabled = true;
    }
}
