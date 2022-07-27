using UnityEngine;
using System.Collections;

public class PlayerMovements : MonoBehaviour
{ 
    private float horizontal;
    public float speed = 8f;
    public float jumpingPower = 16f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if ((Input.GetKeyDown("space") && IsGrounded()) || (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded()) || (Input.GetKeyDown(KeyCode.W) && IsGrounded()))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if ((Input.GetKeyUp("space") && rb.velocity.y > 0f) || (Input.GetKeyUp(KeyCode.UpArrow) && rb.velocity.y > 0f) || (Input.GetKeyUp(KeyCode.W) && rb.velocity.y > 0f))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
