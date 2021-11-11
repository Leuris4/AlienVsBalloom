using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsController : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        float tY = Random.Range(-2, 20);
        float tX = Random.Range(-1f, -5f);
        gameObject.transform.Translate(tX * Time.deltaTime, 0, 0);
        if (gameObject.transform.position.x < -73)
        {
            gameObject.transform.position = new Vector3(73, tY, 0);
        }
    }
}
