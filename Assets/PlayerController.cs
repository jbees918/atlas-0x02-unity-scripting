using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Reference to Rigidbody component
    private Rigidbody rb;

    public float speed = 6f; // Variable to determine the movement speed



    // Init
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from arrow or WASD keys
float moveHorizontal = Input.GetAxis("Horizontal");
float moveVertical = Input.GetAxis("Vertical");

// Debug statements to print input values
    Debug.Log("moveHorizontal: " + moveHorizontal);
    Debug.Log("moveVertical: " + moveVertical);

// Calculate movement vector
Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

// Applies movement to velocity of Rigidbody component
GetComponent<Rigidbody>().velocity = movement * speed;

    }
}
