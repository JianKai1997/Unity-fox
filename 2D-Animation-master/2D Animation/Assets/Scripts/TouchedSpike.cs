using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedSpike : MonoBehaviour
{
    public Transform player;
    public static bool theBool = false;

    //touched spike + enemy
    void OnTriggerEnter2D(Collider2D colliders)
    {
        if (colliders.name.Equals("Player") && theBool == false)
        {
            FindObjectOfType<AudioManager>().Play("Woah");
            player.position = new Vector3(Checkpoint.a, Checkpoint.b, Checkpoint.c);
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
