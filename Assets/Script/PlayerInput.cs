using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    public float playerVelocity = 10f;
    private Rigidbody2D rigidbody2D;
    public Camera camera;

    public AudioSource asource;
    public AudioSource sonmeuh;

    // Use this for initialization
    void Start ()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

	}

    // Update is called once per frame
    void Update()

    {
        camera.transform.position += new Vector3(0.06f,0,0);
        transform.position += new Vector3(0.06f,0,0);

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

            Vector2 velocity =
            new Vector2(rigidbody2D.velocity.x, 0);
            rigidbody2D.velocity = velocity;
            rigidbody2D.gravityScale *=- 1;
            GetComponent<SpriteRenderer>().flipY = !GetComponent<SpriteRenderer>().flipY;
            asource.Play();
            
            
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Obstacle")
        {
            Destroy(gameObject);
            // trigger fin du jeu
            SceneManager.LoadScene("FinDuJeu");
                
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if ( collision.tag == "Bonus carotte")
            {
                collision.gameObject.SetActive(false);
            sonmeuh.Play();
                
            }


    }





}
