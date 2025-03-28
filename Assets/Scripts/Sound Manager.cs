using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip bgm;
    public AudioClip gameOver;
    public float delay = 3f; //CRONOMETRO
    public float timer; //CRONOMETRO

    private GameManager gameManager;

    private bool timerFinished = false;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        gameManager = FindAnyObjectByType<GameManager>().GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(!gameManager.isPlaying && !timerFinished)
        {
            DeathBGM();  
        }*/ 
    }

    void PlayBGM()
    {
        audioSource.clip = bgm;
        audioSource.loop = true;
        audioSource.Play();
    }


    public void PauseBGM()
    {
        if(gameManager.isPaused)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }

    /*public void DeathBGM()
    {
        audioSource.Stop();
        timer += Time.deltaTime; //Como el deltatime calcula el tiempo entre un frame y otro, el TIMER irá sumando el tiempo  //CRONOMETRO
        if(timer >= delay)
        {
            timerFinished = true;
            audioSource.PlayOneShot(gameOver);
        }
    }*/
    public IEnumerator DeathBGM()
    {
        audioSource.Stop();
        yield return new WaitForSeconds(delay);
        audioSource.PlayOneShot(gameOver);
    }

    
}
