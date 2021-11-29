using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float verticalInput;


    // Update is called once per frame
    void Update()
    {
        //tomamos eje horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //tommamos eje bertical 
     //   transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        // rotacion
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

    }
}
