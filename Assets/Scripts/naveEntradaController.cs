using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveEntradaController : MonoBehaviour
{
    int direccion = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(188, 120, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y > 13)
            gameObject.transform.Translate(0, -20f * Time.deltaTime, 0);

        if (direccion == 1)
        {
            gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
        }    
        else if(direccion == 2)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }

        if(gameObject.transform.position.y > 13)
        {
            direccion = 1;
        }else if(gameObject.transform.position.y < -10)
        {
            direccion = 2;
        }
        
    }
}
