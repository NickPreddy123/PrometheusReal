using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatedStopwatch : MonoBehaviour
{
    private float startTime;
    private bool hasStartedLap;

    public GameObject lapText;
    public GameObject lapText2;
    public GameObject lapText3;
    public GameObject lapText4;

    void Update()
    {
        if (hasStartedLap)
        {
            float elapsedTime = Time.time - startTime;
            lapText.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
            lapText2.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
            lapText3.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
            lapText4.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hasStartedLap = true;
        startTime = Time.time;
    }
}
