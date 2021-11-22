using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naveController : MonoBehaviour
{
    public GameObject laserPrefab;
    private float LastShoot;
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
        if(Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.85f)
        {
            shoot();
            LastShoot = Time.time;
        }

        if(gameObject.transform.position.y < -26)
            SceneManager.LoadScene("GameOver");

        if (gameObject.transform.position.y > 26)
            SceneManager.LoadScene("GameOver");
    }

    private void shoot()
    {
        Instantiate(laserPrefab, transform.position + Vector3.left * 10f, Quaternion.identity);
    }
}
