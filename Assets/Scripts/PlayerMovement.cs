using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        
        if (inputX > 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (inputX < 0)
            transform.localScale = new Vector3(1, 1, 1);
        
        rb.velocity = new Vector2(inputX * speed, 0);
    }

    
}
