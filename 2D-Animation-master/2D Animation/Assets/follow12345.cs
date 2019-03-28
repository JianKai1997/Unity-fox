using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow12345 : MonoBehaviour
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
    }
}
