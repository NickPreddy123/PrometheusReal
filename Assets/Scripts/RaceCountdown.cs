using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RaceCountdown : MonoBehaviour
{
    public Text countdownText;
    public float countdownTime = 3f;
    public float countdownInterval = 1f;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        float currentTime = countdownTime;


        Time.timeScale = 0f;

        while (currentTime > 0)
        {
            yield return new WaitForSecondsRealtime(countdownInterval);

            currentTime--;
            if (currentTime == 0)
            {
                countdownText.text = "GO!";
            }
            else
            {
                countdownText.text = currentTime.ToString();
            }
        }


        yield return new WaitForSecondsRealtime(0.5f);
        countdownText.gameObject.SetActive(false);


        Time.timeScale = 1f;
    }
}
