using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{ 
    public float moveSpeed;
    public float jumpSpeed;
    public Rigidbody2D rb;
 
    void Start ()
    {
        rb = GetComponent <Rigidbody2D> ();
    }

    void Update ()
    {
      if (Input.GetKeyDown ("space"))
      {
        rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
      } 
    }
 
    void FixedUpdate ()
    {
        float x = Input.GetAxis ("Horizontal");
        Vector3 move = new Vector3 (x * moveSpeed, rb.velocity.y, 0f);
        rb.velocity = move;
    }
}
