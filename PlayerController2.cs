using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    //these are the private variable.
    public float forwardSpeed = 18.0f;
    public float turnSpeed = 20.0f;
    public float horizontalInput = 0f;
    private float verticalInput = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//we get our vector input;
        horizontalInput = Input.GetAxis("Horizontal2");
        verticalInput = Input.GetAxis("Vertical2");
        
        //Now we are going to make the car forward.
        //transform.Translate(0,0,1);
        //Move forward with speed;
        transform.Translate(Vector3.forward * (Time.deltaTime * forwardSpeed * verticalInput));
        //Move right or ;eft with turn speed;
        transform.Rotate(Vector3.up ,(Time.deltaTime*turnSpeed*horizontalInput));
    }
}
