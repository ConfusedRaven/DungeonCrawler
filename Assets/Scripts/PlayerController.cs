using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    public float moveSpeed;
    public float rotationSpeed;
    public float jumpHeight;
    CharacterController charController;

    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>(); //Grab the character controller
    }

    // Update is called once per frame
    void Update()
    {   //Movement
        if (Input.GetKey(KeyCode.W)) //Press W key to move forward
        {
            charController.Move(transform.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S)) //Press S key to move back
        {
            charController.Move(-transform.forward * Time.deltaTime * moveSpeed);
        }

        //Rotation
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0); //Horizontal rotation
        this.transform.Rotate(this.rotation); //Rotate on move

        //Gravity
        charController.Move(Vector3.down * Time.deltaTime * 9.8f);
    }
}
