using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour {

    [SerializeField]
    private float moveZ;
    [SerializeField]
    private float moveX;

    [SerializeField]
    private float playerSpeed;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private float gravity;
    [SerializeField]
    private float fallVelocity;

    [SerializeField]
    private float rotationSpeed;


    public CharacterController player;

    private Vector3 playerInput;

    private Vector3 movePlayer;
    

    private Vector3 camForward;
    private Vector3 camRight;

    private float rotationY;
    private Quaternion finalRotation;

    // Start is called before the first frame update
    void Start() {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        //cogemos el player input y lo escalamos a un vector factor 1
        playerInput = new Vector3(moveX, 0, moveZ);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;

        movePlayer = movePlayer * playerSpeed;
        player.transform.LookAt(player.transform.position + movePlayer);
        
        setGravity();

        player.Move(movePlayer * Time.deltaTime);
    }
    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
    void setGravity()
    {
        if (player.isGrounded) 
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else 
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
    }
}
