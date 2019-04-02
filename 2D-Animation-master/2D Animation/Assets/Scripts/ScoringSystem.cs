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
    
    void Update()
    {
        if (thelife >= 0)
        {
            scoreText.GetComponent<Text>().text = "Score: " + theScore + "     Life:" + thelife;
        }
        else
        {
            scoreText.GetComponent<Text>().text = "Game Over. Restart in 3 second";
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
            GameObject.Find("Player").GetComponent<Animator>().enabled = false;
            StartCoroutine(restore());
        }

        if (CollectStar.total == 73)
        {
            scoreText.GetComponent<Text>().text = "Congratulation. You Win.";
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
        }
    }

    IEnumerator restore()
    {
        yield return new WaitForSeconds(3);
        thelife = 0;
        theScore = 0;
        CollectStar.total = 0;

        SceneManager.LoadScene("Main");
    }
}
