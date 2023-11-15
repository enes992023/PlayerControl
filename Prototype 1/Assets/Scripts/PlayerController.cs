using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwordInput; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwordInput = Input.GetAxis("Vertical"); 

        //moves the car forword from the Vertical input 
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwordInput);
        //moves the car up or down from horizontal input 
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
    }
}
