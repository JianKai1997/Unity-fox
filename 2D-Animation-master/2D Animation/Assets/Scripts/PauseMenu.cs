using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;

    private bool paused = false;
    
    void Start()
    {
        PauseUI.SetActive(false);
    }

    public void Resume()
    {
        paused = false;
    }

    public void Restart()
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseUI.SetActive(true);
            FindObjectOfType<AudioManager>().Pause("Background");
            Time.timeScale = 0;
        }

        if (!paused)
        {
            PauseUI.SetActive(false);
            FindObjectOfType<AudioManager>().UnPause("Background");
            Time.timeScale = 1;
        }
    }
}
