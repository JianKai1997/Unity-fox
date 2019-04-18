using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;
    public static float a = -1.9f;
    public static float b = 1.0f;
    public static float c = 0.0f;
    Vector3 tempCheck;

    void OnTriggerEnter2D(Collider2D colliders)
    {
        if (colliders.name.Equals("Player"))
        {
            a = gameObject.transform.position.x;
            b = gameObject.transform.position.y;
            c = gameObject.transform.position.z;
            tempCheck = new Vector3(a,b,c);
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("Checkpoint");
            Instantiate(prefabs[0], tempCheck, Quaternion.identity);
        }

    }
}
