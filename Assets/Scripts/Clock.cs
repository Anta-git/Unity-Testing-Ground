using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    private void Update()
    {
        TimeSpan timeSpam = DateTime.Now.TimeOfDay;
        //DateTime dateTime = DateTime.Now;
        //Debug.Log(dateTime.Hour);
        //Debug.Log(dateTime.Minute);
        //Debug.Log(dateTime.Second);
        Quaternion hourRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)timeSpam.TotalHours);
        Quaternion minuteRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)timeSpam.TotalMinutes);
        Quaternion secondRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)timeSpam.TotalSeconds);
        hoursPivot.localRotation = hourRotation;
        minutesPivot.localRotation = minuteRotation;
        secondsPivot.localRotation = secondRotation;
    }

}
