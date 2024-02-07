using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody

    public float fwdForce = 2000f;


    public float speed = 7f;

    void Start()
    {
        // init
    }
    
    void Update()
    {
        rb.AddForce(0, 0, fwdForce * Time.deltaTime);
    }
}
