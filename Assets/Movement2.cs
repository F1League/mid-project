using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //void Update()
     void FixedUpdate ()
     {
         float moveHorizontal = Input.GetAxis("Horizontal");
         float moveVertical = Input.GetAxis("Vertical");

         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
         rb.AddForce(movement);
        {
        }

        {
        }
        {
        }
        {
        }

    }
}