using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isPlaying = true;
    public bool isPaused = false;
    private SoundManager soundManager;
    public GameObject pauseCanvas;
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
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Pause()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            soundManager.PauseBGM();
            pauseCanvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            soundManager.PauseBGM();
            pauseCanvas.SetActive(true);
        }
    }
}
