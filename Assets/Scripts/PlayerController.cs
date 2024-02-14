using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public Text scoreText; // UI Text element for displaying score
    
    // Method to update score UI text
    public void SetScoreText()
    {
        scoreText.text = "Score: " + currentScore; // Assuming currentScore is the variable holding the player's score
    }
    // Ref to Rigidbody
    private Rigidbody rb;

    public float speed = 8f; // Variable to determine the movement speed

     private int score =  0; // Initialize score

     public int health = 2;

      void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++; // Increment score
            Debug.Log("Score: " + score); // Log the new score

            // Destroy coin after collection
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Trap"))
        {
            health--; // Increment score
            Debug.Log("Health: " + health); // Log new score
        }

         if (health == 0)
        { 
            Debug.Log("Game Over!");
            ReloadScene();
        }
        
        if (other.CompareTag("Goal"))
        {
            Debug.Log("You Win!");
            ReloadScene();
        }

    }

    // Init
    void Start()
    {
        
    }

     public void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
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
