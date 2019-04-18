using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    bool count = true;

    void Update()
    {
        if (count)
        {
            StartCoroutine(floatright());
        }
        else if (!count)
        {
            StartCoroutine(floatleft());
        }
    }

    IEnumerator floatright()
    {
        transform.Translate(3 * Time.deltaTime, 0, 0);
        yield return new WaitForSeconds(13);
        count = false;
    }

    IEnumerator floatleft()
    {
        transform.Translate(-3 * Time.deltaTime, 0, 0);
        yield return new WaitForSeconds(13);
        count = true;
    }
}
