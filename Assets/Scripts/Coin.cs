using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private CircleCollider2D circleCollider;
    private AudioSource audioSource;
    public AudioClip CoinSFX;
    private SpriteRenderer renderer;
    


    void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
           
            Interact();
        }
    }


    void Interact()
    {
    
    
        circleCollider.enabled = false;
        renderer.enabled = false;
        audioSource.PlayOneShot(CoinSFX);
        Destroy(gameObject, 0.3f);
    }

}