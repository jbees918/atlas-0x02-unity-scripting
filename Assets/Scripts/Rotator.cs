using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotator : MonoBehaviour
{
    
    public float rotationSpeed = 45f; // Speed of rotation in degrees per second

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update called once per frame
    void Update()
    {
          // Rotate the coin around the X-axis
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }
}
