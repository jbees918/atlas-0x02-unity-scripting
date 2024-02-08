using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Init
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from arrow or WASD keys
float moveHorizontal = Input.GetAxis("Horizontal");
float moveVertical = 0.0f; // Ensure vertical movement is always zero

// Calculate movement vector
Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

// Applies movement to velocity of Rigidbody component
GetComponent<Rigidbody>().velocity = movement * speed;

    }
}
