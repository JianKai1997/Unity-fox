using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedSpike : MonoBehaviour
{
    public Transform player;
    public static bool theBool = false;

    void OnTriggerEnter2D(Collider2D colliders)
    {
        if (colliders.name.Equals("Player") && theBool == false)
        {
            FindObjectOfType<AudioManager>().Play("Woah");
            player.position = new Vector3(-1.9f, 1.0f, 0.0f);
            ScoringSystem.thelife -= 1;
            theBool = true;
        }
    }

    void Update()
    {
        if(theBool == true)
        {
            theBool = false;
        }
    }
}
