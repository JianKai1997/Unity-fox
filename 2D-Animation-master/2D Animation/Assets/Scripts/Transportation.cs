using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transportation : MonoBehaviour
{
    public Transform player;
    Vector3 temp;

    void OnTriggerExit2D(Collider2D colliders)
    {
        temp = player.position;
        temp.x = -1.9f;
        temp.y = 1.0f;
        temp.z = 0.0f;
        player.position = temp;

    }
}
