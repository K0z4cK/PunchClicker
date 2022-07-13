using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private Text Timer;
    void Awake()
    {
        Timer = gameObject.GetComponent<Text>();
        EventManager.Instance.timerTick.AddListener(UpdateTimer);
    }
    void UpdateTimer(int value)
    {
        int mins = value / 60; ;
        float secs = value - mins * 60;

        //Debug.Log(mins + ":" + secs);

        string secSctring;
        if (secs >= 10)
            secSctring = (":" + secs);
        else
            secSctring = (":0" + secs);
        string timerString = ("0" + mins + secSctring);

        Timer.text = timerString;

        if (value > 175)
            Timer.color = Color.green;
        else if (value < 10)
            Timer.color = Color.red;
        else
            Timer.color = Color.white;
    }
}
