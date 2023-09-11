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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = new Vector2(transform.position.x, transform.position.y);
        targetLocation = new Vector2(startPosition.x + 1, startPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (targetLocation.x - startPosition.x > 0) {
            direction = 1;
        } else if (targetLocation.x - startPosition.x < 0) {
            direction = -1;
        }

        if (transform.position.x != targetLocation.x) {
            rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        } else if (direction == 1) {
            targetLocation = new Vector2(startPosition.x - 1, startPosition.y);
        } else {
            targetLocation = new Vector2(startPosition.x + 1, startPosition.y);
        }
    }
}
