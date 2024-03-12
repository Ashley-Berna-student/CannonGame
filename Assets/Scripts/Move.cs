using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float moveSpeed = 1.0f;
    public float jumpForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalImput = Input.GetAxis("Horizontal");

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //transform.localScale = Vector3.one;
        //}

        //if (Input.GetKey(KeyCode.Space))
        //{
            //transform.localScale += Vector3.one * Time.deltaTime;
        //}

        //if (Input.GetKeyUp(KeyCode.Space))
        //{
            //transform.localScale = Vector3.one;
        //}

        Vector3 moveDirection = Vector3.forward * moveSpeed * horizontalImput * Time.deltaTime;
        rigidbody.AddForce(moveDirection,ForceMode.Acceleration);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpDirection = Vector3.up * jumpForce;
            rigidbody.AddForce(jumpDirection, ForceMode.VelocityChange);
        }

        Vector3 velocity = rigidbody.velocity;
        velocity.y = 0.0f;
        if (velocity.magnitude > 0.0f) 
        {
            transform.rotation = Quaternion.LookRotation(velocity);
        }
        
    }
}
