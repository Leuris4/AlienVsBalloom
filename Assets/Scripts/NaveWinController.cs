using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveWinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(225, 110, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var x = gameObject.transform.localScale.x;
        var y = gameObject.transform.localScale.y;
        var z = gameObject.transform.localScale.z;
        if(gameObject.transform.position.y > -42 && gameObject.transform.position.x > 22)
        {
            gameObject.transform.Translate(-65f * Time.deltaTime, -50f * Time.deltaTime, 0);
            gameObject.transform.localScale = new Vector3(x + Time.deltaTime * 1, y + Time.deltaTime * 1, x + Time.deltaTime * 1);
        }
    }
}
