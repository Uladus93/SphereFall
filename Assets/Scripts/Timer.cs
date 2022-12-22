using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private static float _timerTime;
    public static float TimerTime
    {
        get { return _timerTime; }
        set
        {
            _timerTime = value;
            if (TimerTime < 0)
            {
                TimerTime = 0;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerTime += Time.deltaTime;
    }
}
