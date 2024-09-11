using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClockDigital : MonoBehaviour
{
    //private Text textClock;
    private TextMeshProUGUI textClock;

    private void Awake()
    {
        textClock = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        DateTime time = DateTime.Now;
        String hour = LeadingZero( time.Hour );
        string minute = LeadingZero (time.Minute );
        string second = LeadingZero ((time.Second));

        textClock.text = hour + ":" + minute + ":" + second;

    }

    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
