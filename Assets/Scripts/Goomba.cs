using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{

    private Animator animator;
    private AudioSource audioSource;

    public AudioClip goombadeathSFX;
    private Rigidbody2D rigidBody;
    public int direction = -1;
    public float speed = 5;

    private BoxCollider2D boxCollider;
    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Start()
    {
        speed = 0;
    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(direction * speed, rigidBody.velocity.y);
    }

    public void Death()
    {
        direction = 0;
        rigidBody.gravityScale = 0;
        animator.SetTrigger("IsDead");
        boxCollider.enabled = false;
        Destroy(gameObject, 0.3f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Tuberia") || collision.gameObject.layer == 6 || collision.gameObject.layer == 9)
        {
            direction *= -1;
        }
        
        if(collision.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Mario playerScript = collision.gameObject.GetComponent<Mario>();
            playerScript.Death();
        }
        
    }


    void OnBecameVisible()
    {
        speed = 2;
    }

    void OnBecameInvisible()
    {
        speed = 0;
    }
}

