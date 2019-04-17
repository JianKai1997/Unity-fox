using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public static int thelife;
    public static string theStatus = "Welcome !";
    
    void Start()
    {
        initiallizeAll();
    }

    void Update()
    {
        if (thelife >= 0)
        {
            scoreText.GetComponent<Text>().text = "Score: " + theScore + "     Life:" + thelife;
        }
        else
        {
            theStatus = "You Lose";
            SceneManager.LoadScene(0);
        }


        if (CollectStar.total == 73)
        {
            scoreText.GetComponent<Text>().text = "Congratulation. You Win.";
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
            theStatus = "Congratulation";
            SceneManager.LoadScene(0);
        }
    }

    public void initiallizeAll()
    {
        thelife = 0;
        theScore = 0;
        CollectStar.total = 0;
    }
}
