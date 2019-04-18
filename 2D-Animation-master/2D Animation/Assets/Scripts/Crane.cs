using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crane : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;
    public static bool crankStatus = false;
    public Transform player;

    Vector3 tempCrank = new Vector3(-4.05f, 22.9f, 0.00f);

    void OnTriggerEnter2D(Collider2D colliders)
    {
        if (CollectStar.total >= 23)
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("CrankUnlock");
            crankStatus = true;
            Instantiate(prefabs[0], tempCrank, Quaternion.identity);
        }
    }
}
