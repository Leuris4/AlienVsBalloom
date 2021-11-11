using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserController : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Vector2.left * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if(gameObject.transform.position.x < -72f)
        {
            Destroy(gameObject);
        }
    }
}
