using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDogMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField] public float speed = 10f;
    void Update()
    {
        
        if (transform.position.x == 9){
            rb.AddForce(Vector2.right * speed);
        }
        if (transform.position.x == 18) {
            rb.AddForce(Vector2.left * speed);
        }
        rb.AddForce(Vector2.left * speed);

    }
}
