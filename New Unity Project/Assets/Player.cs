using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public float maxX = 7.5f;
    float movementeHorizontal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementeHorizontal = Input.GetAxis("Horizontal");
        if ((movementeHorizontal > 0 && transform.position.x < maxX) || (movementeHorizontal < 0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right * movementeHorizontal * speed * Time.deltaTime;
        }

    }
}
