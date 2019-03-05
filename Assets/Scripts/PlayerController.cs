using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float gravity;
    private int count;
    public TextMeshProUGUI countText;

    // Update is called once per frame
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        updateCount();
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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            updateCount();
        }
        //Destroy(other.gameObject);
    }
    void updateCount()
    {
        countText.text = "Score: " + count.ToString();
    }
}
