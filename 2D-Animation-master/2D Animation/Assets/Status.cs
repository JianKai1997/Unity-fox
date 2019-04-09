using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    string currentStatus;
    public GameObject playerStatus;

    // Update is called once per frame
    void Update()
    {
        //currentStatus = ScoringSystem.theStatus;
        playerStatus.GetComponent<Text>().text = ScoringSystem.theStatus;
    }
}
