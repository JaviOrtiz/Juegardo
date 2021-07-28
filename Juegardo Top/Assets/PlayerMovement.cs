using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 movement;

    public Rigidbody rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.z = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {

        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);



    }
}
