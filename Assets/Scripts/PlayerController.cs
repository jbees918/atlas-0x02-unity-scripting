using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Reference to Rigidbody component
    private Rigidbody rb;

    public float speed = 6f; // Variable to determine the movement speed

     private int score =  0; // Initialize the score

     public int health = 5;

      void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++; // Increment the score
            Debug.Log("Score: " + score); // Log the new score

            // Destroy coin after collection
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Trap"))
        {
            health--; // Increment the score
            Debug.Log("Health: " + health); // Log the new score

        }

         if(--health <= 0)
        {
                Debug.Log("Game Over!");
        }
        
        if (other.CompareTag("Goal"))
        {
            Debug.Log("You Win!"); 
        }



    }



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
