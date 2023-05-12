using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stopwatch : MonoBehaviour
{
    public Text stopwatchText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        string milliseconds = ((t * 1000) % 1000).ToString("000");

        stopwatchText.text = minutes + ":" + seconds + ":" + milliseconds;
    }
}


