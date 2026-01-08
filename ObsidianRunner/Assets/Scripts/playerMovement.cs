using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField]float moveSpeed = 10f;
    [SerializeField]float JumpForce = 50f;
    

    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right")){
            rb.AddForce(Vector2.right * moveSpeed);
        }

        if (Input.GetKey("a") || Input.GetKey("left")){
            rb.AddForce(Vector2.left * moveSpeed);
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * JumpForce);
        }
    }
}
