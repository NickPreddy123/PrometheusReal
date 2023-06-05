using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatedStopwatch : MonoBehaviour
{
    private float startTime;
    private bool hasStartedLap;

    public GameObject lapText;
    

    void Update()
    {
        if (hasStartedLap)
        {
            float elapsedTime = Time.time - startTime;
            lapText.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hasStartedLap = true;
        startTime = Time.time;
    }
}
