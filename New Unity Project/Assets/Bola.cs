using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    public float minY = -5.5f;
    public float maxVelocity = 11f;
    public float minVelocity = 11f;
    Rigidbody2D rb;
    
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * 10f;
    }



    void Update()
    {
        if (transform.position.y < minY)
        {
            SceneManager.LoadScene("Menumorte");
        }
        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }

        if (rb.velocity.magnitude > minVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, minVelocity);
        }
    }
}
