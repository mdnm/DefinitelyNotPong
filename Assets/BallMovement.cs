using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float initialSpeed;
    public GameController gameController;
    private float currentSpeed;
    private bool wasHitByPlayer;
    private new Rigidbody2D rigidbody2D;
    private Vector2 direction;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Initiate();
    }

    private void Initiate()
    {
        transform.position = new Vector3(0, 0, 0);

        currentSpeed = initialSpeed;
        wasHitByPlayer = false;
        
        int x = Random.Range(0, 2) == 0 ? -1 : 1;
        int y = Random.Range(0, 2) == 0 ? -1 : 1;
        rigidbody2D.velocity = new Vector2(initialSpeed * x, initialSpeed * y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            HandlePlayerHit();
        }
    }

    private void HandlePlayerHit()
    {
        if (wasHitByPlayer) return;

        wasHitByPlayer = true;
        rigidbody2D.velocity *= 2;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string tag = other.tag;
        if (tag.Contains("Goal"))
        {
            PlayerSide goalSide = tag.Equals("LeftGoal") ? PlayerSide.Left : PlayerSide.Right;
            gameController.AddScore(goalSide);

            Initiate();
            return;
        }
    }
}
