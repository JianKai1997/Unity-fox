using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transportation : MonoBehaviour
{
    public Transform player;

    void OnTriggerEnter2D(Collider2D colliders)
    {
        player.position = new Vector3(-1.9f, 1.0f, 0.0f);
    }
}
