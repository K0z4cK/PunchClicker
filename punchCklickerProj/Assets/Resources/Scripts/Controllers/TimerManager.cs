using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class TimerManager : SingletonComponent<TimerManager>
{
    internal int Time
    {
        get
        {
            return time;
        }

        private set
        {
            if (value > -1)
            {
                time = value;
            }
        }
    }
    private void Awake()
    {
        StartTimer(111);
    }
    [SerializeField] private int time = 0;


    IEnumerator TimerCoroutine()
    {
        do
        {
            Time--;
            EventManager.Instance.OnTimerTick(Time);
            yield return new WaitForSeconds(1f);
        } while (Time > -1);
    }

    internal void StartTimer(int value)
    {
        Time = value;
        StartCoroutine("TimerCoroutine");
    }
    private void StopTimer()
    {
        StopAllCoroutines();
    }
} 
