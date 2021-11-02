using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComradeController : MonoBehaviour
{
    [SerializeField]
    GameObject FollowTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FollowTarget != null)
        {

        }
    }


    public void WhoWillFollow(GameObject _target) 
    {
        if (_target != null)
        {
            FollowTarget = _target;
            //Opcion 1
            InteractuableObjectController objCont = gameObject.GetComponent<InteractuableObjectController>();
            objCont.enabled = false; //tambien se puede destruir
            SphereCollider objSphere = gameObject.GetComponent<SphereCollider>();
            gameObject.tag = "Untagged";

            // Opcion 2 
            //crear un nuevo objeto que siga al player y destruir este

        }
        
    }
}
