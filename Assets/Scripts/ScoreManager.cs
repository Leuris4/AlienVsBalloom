using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    public Text scoreText;
    public Text timeText;
    int score = 0;
    int minutos = 0;

    void Start()
    {
        scoreManager = this;
    }

    public void RaiseScore(int s)
    {
        score += s;
        if(score > 0)
        {
            scoreText.text = score.ToString();
        }else
        {

        }
        
    }

    public void RaiseTime(float time)
    {
        if(time < 60)
        {
            if(Convert.ToInt32(time) <= 9)
            {
                timeText.text = minutos.ToString() + ":0" + Convert.ToInt32(time).ToString();
            }else
            {
                timeText.text = minutos.ToString() + ":" + Convert.ToInt32(time).ToString();
            }
            
        }
        else
        {
            minutos++;
            time = 0;
        }

        
    }
}
