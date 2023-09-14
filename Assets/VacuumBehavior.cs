using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumBehavior : MonoBehaviour
{
    public float speed;
    private float direction;

    private Rigidbody2D rb;
    private Vector2 startPosition;
    private Vector2 targetLocation;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = new Vector2(transform.position.x, transform.position.y);
        targetLocation = new Vector2(startPosition.x + 1, startPosition.y);
        direction = 1;

        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= targetLocation.x) {
            targetLocation.x = startPosition.x - 1;
            direction = -1;
            spriteRenderer.flipX = false;
            rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        } else {
            targetLocation.x = startPosition.x + 1;
            direction = 1;
            spriteRenderer.flipX = true;
            rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        }
    }
}
