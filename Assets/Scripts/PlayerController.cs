using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This is a reference to the Rigidbody component
    private Rigidbody rb;

    public float speed = 5f; // Variable that determines the movement speed

    void Start()
    {
        // Get the Rigidbody component attached to the same GameObject
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Capture input for horizontal and vertical movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply movement to the Rigidbody component's velocity
        rb.velocity = movement * speed;
    }
}
