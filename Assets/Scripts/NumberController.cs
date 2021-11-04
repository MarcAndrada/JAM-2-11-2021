using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberController : MonoBehaviour
{

    [SerializeField]
    private GameObject particulas;
    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = particulas.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Rotate(new Vector3(0,0,-1),180);
        
    }
}
