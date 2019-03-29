using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDiamond : MonoBehaviour
{
    void Start()
    {
        
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        if (CollectStar.total >= 23)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
