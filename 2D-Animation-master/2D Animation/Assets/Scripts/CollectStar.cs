using UnityEngine;

public class CollectStar : MonoBehaviour
{
    //public AudioSource collectSound;
    public static int total;

    void OnTriggerExit2D(Collider2D colliders)
    {
        //collectSound.Play();

        if (gameObject.name.Equals("cherry"))
        {
            ScoringSystem.theScore += 5;
            total += 5;
        }
        else if (gameObject.name.Equals("Big Diamond"))
        {
            ScoringSystem.theScore += 50;
        }
        else
        {
            ScoringSystem.theScore += 1;
            total += 1;
        }

        while (ScoringSystem.theScore >= 10)
        {
            ScoringSystem.theScore -= 10;
            ScoringSystem.thelife += 1;
        }

        Destroy(gameObject);
    }
}
