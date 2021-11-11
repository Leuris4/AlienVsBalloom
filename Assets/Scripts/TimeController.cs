using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int verifier = 0;
    // Update is called once per frame
    void Update()
    {

        ScoreManager.scoreManager.RaiseTime(Time.time);
        if (Convert.ToInt32(Time.time) % 10 == 0 && Time.time > 1)
        {
            if(verifier != Convert.ToInt32(Time.time))
            {
                ScoreManager.scoreManager.RaiseScore(-5);
                verifier = Convert.ToInt32(Time.time);
            }
        }
    }
}
