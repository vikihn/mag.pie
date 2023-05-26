using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour


{
    Rigidbody2D rb;
    public int speed;
    Vector2 movement;
    SpriteRenderer spriteRenderer;
    bool IsJumping = false;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        float x = Input.GetAxis("Horizontal");
        movement.x = x;

        if (Input.GetKeyDown("space")) { IsJumping = true; }

        if (movement.x > 0) { spriteRenderer.flipX = false; }
        if (movement.x < 0) { spriteRenderer.flipX = true; }

    }

    private void FixedUpdate()
    {
        Move();
        if (IsJumping) { Jump(); }

    }

    private void Move()
    {
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }
    private void Jump()
    {
        rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        IsJumping = false;
    }

}


