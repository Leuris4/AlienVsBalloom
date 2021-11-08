using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down") && gameObject.transform.position.y >= -26)
        {
            gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
        }
        if (Input.GetKey("up") && gameObject.transform.position.y <= 26)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
    }
}
