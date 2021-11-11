using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globoController : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.scoreManager.RaiseScore(1);
        Destroy(gameObject);
    }

    void Update()
    {
        float tY = Random.Range(10f, 20f);
        gameObject.transform.Translate(0, tY * Time.deltaTime, 0);
        if(gameObject.transform.position.y > 30f)
        {
            Destroy(gameObject);
        }
    }

}
