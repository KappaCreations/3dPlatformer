using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpSpeed = 8;
    
    [SerializeField]
    bool touchingFloor = false;

    
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = new Ray(transform.position, new Vector3(0,-.5f,0));
        Debug.DrawRay(r.origin, r.direction);
        //RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.down, .5f))
                touchingFloor = true;

            else
                touchingFloor = false;


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

       rb.velocity = new Vector3(h * moveSpeed, rb.velocity.y, v * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            Jump(touchingFloor);

        }


        
    }

    void Jump(bool a)
    {
        if (a)
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        else
            Debug.Log("Not touching ground");
    
    }



}
