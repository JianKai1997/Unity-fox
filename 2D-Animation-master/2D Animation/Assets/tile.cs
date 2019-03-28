using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    //public float speed = 10f;
    bool count;

    void Start()
    {
        count = true;
    }

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
        //print("comefloatup");
        transform.Translate(0, 1 * Time.deltaTime, 0);
        yield return new WaitForSeconds(5);
        count = false;
    }

    IEnumerator floatdown()
    {
        //print("comefloatdown");
        transform.Translate(0, -1 * Time.deltaTime, 0);
        yield return new WaitForSeconds(5);
        count = true;
    }

}
