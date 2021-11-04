using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private GameObject textGameObject;

    private int requiredCompanion;
    private int playerCompanion;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = particulas.transform.position;

        textGameObject = GetComponent<GameObject>();

        requiredCompanion = anim.GetRequiredCompanions();
        playerCompanion = companionCount.GetCompanions();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerCompanion < requiredCompanion) {
            textGameObject.GetComponent<UnityEngine.UI.Text>().text = "3";
        }
        else
        {
            textGameObject.GetComponent<UnityEngine.UI.Text>().text = "E";
        }
        transform.LookAt(player.transform.position);
        transform.Rotate(new Vector3(0,0,-1),180);
    }
}
