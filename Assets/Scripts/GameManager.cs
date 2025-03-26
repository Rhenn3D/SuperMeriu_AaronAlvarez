using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPlaying = true;
    public bool isPaused = false;
    private SoundManager soundManager;
    void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>().GetComponent<SoundManager>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            Pause();
        }        
    }
    void Pause()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            soundManager.PauseBGM();
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            soundManager.PauseBGM();
        }
    }
}
