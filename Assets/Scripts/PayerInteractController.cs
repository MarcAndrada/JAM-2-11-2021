using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerInteractController : MonoBehaviour
{
    private bool canInteract;
    private int companions;

    private InteractuableObjectController objCont;

    private QueueController queueCont;
    // Start is called before the first frame update
    void Start()
    {
        queueCont = gameObject.GetComponent<QueueController>();
    }

    // Update is called once per frame
    void Update()
    {
        //si aprieta el boton de interactuar y esta cerca de algun objeto
        if (true && canInteract && objCont != null)
        {
            //comprobamos que el numero de camaradas que tenemos sea suficiente para hacer la accion
            if (objCont.GetRequiredCompanions() <= companions)
            {
                //hacer animacion
                //si la final pos del objeto es diferente a 0 haremos tp al player a esa posicion
                if (objCont.GetFinalPos().x != 0 && objCont.GetFinalPos().y != 0)
                {
                    //hacemos tp al player a la final pos y desactivamos su mesh 
                }
                else
                {
                    //remarcar cartel de camaradas necesarios
                }
            }
            //cuando haya acabado la animacion hacemos que el player aparezca de nuevo

        }       
    }

    private void OnTriggerEnter(Collider collision)
    {
        //detectamos si tenemos algun objeto cerca
        if (collision.gameObject.tag == "Object"){
            objCont = collision.GetComponent<InteractuableObjectController>();
            if (objCont.IsAnim())
            {    
                canInteract = true;
            }
            else 
            {
                companions++;
                queueCont.AddNewComrade(collision.gameObject);
                objCont = null;
                //hacer funcion de añadir camarada a la cola
            }
        }
    }

    private void OnTriggerExit(Collider collision) 
    {
        if (collision.gameObject.tag == "Object")
        {
            canInteract = false;
            objCont = null;
        }
    }

}
