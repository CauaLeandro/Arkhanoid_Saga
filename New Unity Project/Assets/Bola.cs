using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float minY = -5.5f;
    public float maxVelocity = 15f;
    Rigidbody2D rb;
    
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    


void Update()
    {
        if (transform.position.y < minY)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
        }
        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }
    }
}
