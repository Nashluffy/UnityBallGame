using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float gravity;
    // Update is called once per frame
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
    }
    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveZed = Input.GetAxis("Jump");
        Vector3 movement = new Vector3 (moveHorizontal, moveZed * (gravity/speed), moveVertical);
        rb.AddForce (movement * speed);
        
    }
}
