using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerInteractController : MonoBehaviour
{
    private bool canInteract;
    private int companions;

    private InteractuableObjectController objCont;

    private QueueController queueCont;

    private float TimeToWait = 20;
    private float TimeWaited;
    [SerializeField]
    private GameObject inGameOptions;
    [SerializeField]
    private MainMenu options;
    private CanvasTextController ObjectText;
    private bool Do = false;
    [SerializeField]
    Text HUDText;

    // Start is called before the first frame update
    void Start()
    {

        queueCont = gameObject.GetComponent<QueueController>();
        HUDText.text = companions.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (Do)
        {
            TimeWaited += Time.deltaTime;

        
            if (TimeToWait < TimeWaited)
            {
                SceneManager.LoadScene(5); 
            }
        }

        //si aprieta el boton de interactuar y esta cerca de algun objeto
        if (Input.GetKey(KeyCode.E) && canInteract && objCont != null)
        {
            //comprobamos que el numero de camaradas que tenemos sea suficiente para hacer la accion
            if (objCont.GetRequiredCompanions() <= companions)
            {
                PlayableDirector director;
                director = GameObject.Find(objCont.GetAnimName()).GetComponent<PlayableDirector>();
                director.Play();
                if (objCont.GetAnimName() == "EscapeVentanaTimeLine")
                {
                    Do = true;
                }

                //SceneAnim.SetTrigger(objCont.GetAnimName());
                //hacer animacion
                //si la final pos del objeto es diferente a 0 haremos tp al player a esa posicion
                if (objCont.GetFinalPos().x != 0 && objCont.GetFinalPos().y != 0)
                {
                    //hacemos tp al player a la final pos y desactivamos su mesh 
                    while (transform.position != objCont.GetFinalPos())
                    {
                        transform.position = objCont.GetFinalPos();
                    }
                }
                
            }

            //cuando haya acabado la animacion hacemos que el player aparezca de nuevo

        }
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            inGameOptions.SetActive(true);
            options.PauseGame();
        } else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            inGameOptions.SetActive(false);
            options.ResumeGame();
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
                ObjectText = collision.gameObject.GetComponentInChildren<CanvasTextController>();
                ObjectText.ActivateNumber();
                
            }
            else 
            {

                companions++;
                queueCont.AddNewComrade(collision.gameObject);
                objCont = null;
                HUDText.text = companions.ToString();
                //hacer funcion de añadir camarada a la cola
            }
        }
    }

    private void OnTriggerExit(Collider collision) 
    {
        if (collision.gameObject.tag == "Object")
        {
            if (ObjectText != null)
            {
                ObjectText.DesapearNumber();
            }
            canInteract = false;
            objCont = null;
        }
    }

    public int GetCompanions()
    {
        return companions;
    }
}
