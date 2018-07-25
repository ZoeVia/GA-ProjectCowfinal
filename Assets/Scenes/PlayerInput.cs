using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float playerVelocity = 10f;
    private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start ()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        /*
        float horizontalAxis = Input.GetAxis("Horizontal");
        Vector2 velocity =
            new Vector2(horizontalAxis * playerVelocity , rigidbody2D.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = 10;
        }
        rigidbody2D.velocity = velocity;*/

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2D.gravityScale *=- 1;
            GetComponent<SpriteRenderer>().flipY = !GetComponent<SpriteRenderer>().flipY;
        }
    }
}
