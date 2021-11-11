using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azulController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.scoreManager.RaiseScore(10);
        Destroy(gameObject);
    }

    void Update()
    {
        float tY = Random.Range(20f, 30f);
        gameObject.transform.Translate(0, tY * Time.deltaTime, 0);
        if (gameObject.transform.position.y > 30f)
        {
            Destroy(gameObject);
        }
    }
}
