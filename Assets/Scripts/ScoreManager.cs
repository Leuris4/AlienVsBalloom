using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    public Text scoreText;
    public Text timeText;
    int score = 10;
    int minutos = 0;
    int segundos = 0;
    int segundo = 0;

    void Start()
    {
        scoreManager = this;
        scoreText.text = score.ToString();
    }

    public void RaiseScore(int s)
    {
        score += s;
        if(score > 0)
        {
            scoreText.text = score.ToString();
        }else
        {
            SceneManager.LoadScene("GameOver");
        }

        if(score >= 50)
        {
            SceneManager.LoadScene("Win");
        }
        
    }

    public void RaiseTime(float time)
    {
        if(segundos <= 9)
        {
            timeText.text = minutos.ToString() + ":0" + segundos.ToString();
        }else
        {
            timeText.text = minutos.ToString() + ":" + segundos.ToString();
        }
        if(segundo < time)
        {
            segundo++;
            if (segundo % 60 == 0 && segundo > 0)
            {
                segundos = 0;
                minutos++;
            }
        }
        if(segundo%60 > segundos)
        {
            if (segundos < 60)
            {
                segundos++;
            }
        }
        


    }
}
