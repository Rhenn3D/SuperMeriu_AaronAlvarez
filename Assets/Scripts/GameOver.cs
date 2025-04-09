using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMario;
    public BoxCollider2D boxCollider;
    private AudioSource audioSource;
    public AudioClip SoundGameOver;

    void Awake()
    {
        boxCollider = GetComponentInChildren <BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
        SoundGameOver = GetComponent<AudioClip>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Mario playerScript = collision.gameObject.GetComponent<Mario>();
            playerScript.Death();
            audioSource.PlayOneShot(SoundGameOver);

        }
        
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
}
