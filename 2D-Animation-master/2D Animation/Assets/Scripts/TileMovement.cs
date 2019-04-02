using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    bool count = true;

    void Update()
    {
        if (count)
        {
            StartCoroutine(floatup());
        }
        else if (!count)
        {
            StartCoroutine(floatdown());
        }
    }

    IEnumerator floatup()
    {
        transform.Translate(0, 1 * Time.deltaTime, 0);
        yield return new WaitForSeconds(5);
        count = false;
    }

    IEnumerator floatdown()
    {
        transform.Translate(0, -1 * Time.deltaTime, 0);
        yield return new WaitForSeconds(5);
        count = true;
    }
}
