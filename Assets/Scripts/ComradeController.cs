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

    SphereCollider objSphere;
    BoxCollider objColl;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        objSphere = gameObject.GetComponent<SphereCollider>();
        objColl = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FollowTarget != null)
        {

            Vector3 Pos = new Vector3(FollowTarget.transform.localPosition.x, FollowTarget.transform.localPosition.y , FollowTarget.transform.localPosition.z - offset);
            
            gameObject.transform.LookAt(FollowTarget.transform.position);
            transform.position = Vector3.Lerp(transform.position, Pos, Speed * Time.deltaTime);
        }
    }


    public void WhoWillFollow(GameObject _target) 
    {
        if (_target != null)
        {
            FollowTarget = _target;
            //Opcion 1
            InteractuableObjectController objCont = gameObject.GetComponent<InteractuableObjectController>();
            
           
            
            gameObject.tag = "Untagged";
            objCont.enabled = false; //tambien se puede destruir
            objSphere.enabled = false;
            //objColl.enabled = false;
            gameObject.layer = 8;
           // gameObject.transform.parent = _target.transform;
        }
        
    }
}
