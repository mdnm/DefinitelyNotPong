using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private new Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    private void Start()
    {
//        speed = new Vector2(0, 4f);
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, translation);
    }
}
