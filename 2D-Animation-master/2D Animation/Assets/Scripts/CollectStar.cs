using UnityEngine;

public class CollectStar : MonoBehaviour
{
    //public AudioSource collectSound;
    public static int total;
    string theObjectName = ""; 

    void OnTriggerEnter2D(Collider2D colliders)
    {
        if (theObjectName != gameObject.name)
        {
            //collectSound = GetComponent<AudioSource>();
            //collectSound.Play();
            if (gameObject.name.Equals("cherry"))
            {
                ScoringSystem.theScore += 5;
                total += 5;
            }
            else if (gameObject.name.Equals("Big Diamond(Clone)"))
            {
                ScoringSystem.theScore += 50;
                total += 50;
            }
            else
            {
                ScoringSystem.theScore += 1;
                total += 1;
            }

            theObjectName = gameObject.name;
        }
        

        while (ScoringSystem.theScore >= 10)
        {
            ScoringSystem.theScore -= 10;
            ScoringSystem.thelife += 1;
        }

        Destroy(gameObject);
    }
}
