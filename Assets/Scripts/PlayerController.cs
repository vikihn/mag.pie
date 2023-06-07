using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
    public float jumpForce = 5f;
    public float raycastDistance = 0.1f;
    public LayerMask groundLayer;
    public int speed;

    private float originalSpeed;
    Vector2 movement;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    private bool isGrounded;

    private Animator anim;
    


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSpeed = speed;
    }


    private void Update()
    {

        float x = Input.GetAxis("Horizontal");
        movement.x = x;

        // Perform ground check
        isGrounded = GroundCheck();

        if (isGrounded)
        {
            // Jump input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Apply jump force
                anim.SetTrigger("jump");
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }

        }

        if (x == 0)
        {
            anim.SetBool("isWalking", false);
        }

        else
        {
            anim.SetBool("isWalking", true);
        }

        if (movement.x > 0) { spriteRenderer.flipX = false; }
        if (movement.x < 0) { spriteRenderer.flipX = true; }

    }

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }
    
    private bool GroundCheck()
    {
        // Cast a ray downwards and check for collisions with the ground layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, groundLayer);
        return hit.collider != null;
    }

    //Items Collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SlowDownItem"))
        {
            speed -= 1;
        }

        if (collision.CompareTag("SpeedUpItem"))
        {
            speed += 3;
        }

        if (collision.CompareTag("WeakPoint"))
        {
            CatSleep.sleep = true;
        }
        if (collision.CompareTag("WeakPointTwo"))
        {
            CatSleep2.sleep2 = true;
        }
    }


}
