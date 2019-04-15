using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMEnu : MonoBehaviour
{
    public void playGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();

        //here need enabled if use unity to test
        //disable only when create desktop .exe file 
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
