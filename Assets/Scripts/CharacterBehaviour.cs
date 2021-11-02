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

    public CharacterController player;

    // Start is called before the first frame update
    void Start() {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(moveX, 0, moveZ) * playerSpeed * Time.deltaTime);
    }
}
