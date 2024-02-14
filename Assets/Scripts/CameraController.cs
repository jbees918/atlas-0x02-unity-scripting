using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Reference to player object
    public GameObject player;

    // Offset from player position
    public Vector3 offset = new Vector3(0,  2, -5);

    void Update()
    {
         // Set position of the camera to player position plus soffset
        transform.position = player.transform.position + offset;
    }
}
