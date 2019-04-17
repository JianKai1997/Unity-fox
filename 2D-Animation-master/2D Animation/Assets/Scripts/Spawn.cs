using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;

    private bool theBool = false; //prevent spawn amny big diamond
    Vector3 tempDiamond = new Vector3(3.54f, 9.67f, 2.03f);

    void Update()
    {
        if (CollectStar.total >= 23 && theBool == false && Crane.crankStatus == true)
        {
            Instantiate(prefabs[0], tempDiamond, Quaternion.identity);
            theBool = true;           
        }
    }
}
