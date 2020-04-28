using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{

    public Text score;

    private void Awake()
    {
        score.text = Mathf.Floor(WaveSpawner.TimeBetweenWaves).ToString(CultureInfo.InvariantCulture);
    }

    private void FixedUpdate()
    {
        score.text = Mathf.Floor(WaveSpawner.Countdown).ToString(CultureInfo.InvariantCulture);

        if (Mathf.Floor(WaveSpawner.Countdown) == 0)
        {
            score.text = " ";
        }
    }
}
