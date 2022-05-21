using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    private new Rigidbody2D rigidbody2D;
    public Vector2 direction;

    // Start is called before the first frame update
    private void Start()
    {
        direction = new Vector2(Random.Range(-1, 1.1f), Random.Range(-1, 1.1f));
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rigidbody2D.velocity = direction * speed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Boundary")) {
            direction.y *= -1;
        } else {
            direction.x *= -1;
        }
    }
}
