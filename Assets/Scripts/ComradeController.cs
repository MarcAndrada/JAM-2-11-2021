using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComradeController : MonoBehaviour
{
    [SerializeField]
    private GameObject FollowTarget;
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (FollowTarget != null)
        {
            Vector3 objPos = new Vector3(0, 0, -offset);
            gameObject.transform.LookAt(FollowTarget.transform.position);
            transform.position = Vector3.MoveTowards(objPos, objPos, Speed);
        }
    }


    public void WhoWillFollow(GameObject _target) 
    {
        if (_target != null)
        {
            FollowTarget = _target;
            //Opcion 1
            InteractuableObjectController objCont = gameObject.GetComponent<InteractuableObjectController>();
            SphereCollider objSphere = gameObject.GetComponent<SphereCollider>();
            BoxCollider objColl = gameObject.GetComponent<BoxCollider>();
           
            
            transform.parent = _target.transform;
            gameObject.tag = "Untagged";
            objCont.enabled = false; //tambien se puede destruir
            objSphere.enabled = false;
            objColl.enabled = false;

        }
        
    }
}
