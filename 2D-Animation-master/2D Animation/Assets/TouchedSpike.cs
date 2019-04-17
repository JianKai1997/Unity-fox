using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedSpike : MonoBehaviour
{
    public Transform player;

    void OnTriggerEnter2D(Collider2D colliders)
    {
        FindObjectOfType<AudioManager>().Play("Woah");
        player.position = new Vector3(-1.9f, 1.0f, 0.0f);
        ScoringSystem.thelife -= 1;
    }
}
