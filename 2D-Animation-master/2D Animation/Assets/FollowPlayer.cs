using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if ((player.position.x > transform.position.x) || (player.position.x < transform.position.x))
        {
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }

        if ((player.position.y > transform.position.y) || (player.position.y < transform.position.y))
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }

        //drop down die
        if (player.position.y <= -20.0)
        {
            FindObjectOfType<AudioManager>().Play("Woah");
            player.position = new Vector3(-1.9f, 1.0f, 0.0f);
            ScoringSystem.thelife -= 1;
        }
    }
}
