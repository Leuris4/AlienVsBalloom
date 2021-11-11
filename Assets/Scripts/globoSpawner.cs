using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globoSpawner : MonoBehaviour
{
    float timer;
    public GameObject globoRojoPrefab;
    public GameObject globoAmarilloPrefab;
    public GameObject globoVerdePrefab;
    public GameObject globoAzulPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int globo = Random.Range(1, 5);
        float time = Random.Range(1f, 2f);
        if(timer >= time)
        {
            timer = 0;
            float x = Random.Range(-62f, 20f);
            Vector3 position = new Vector3(x, -34, 0);
            Quaternion rotation = new Quaternion();
            switch (globo)
            {
                case 1:
                    Instantiate(globoRojoPrefab, position, rotation);
                    break;
                case 2:
                    Instantiate(globoAmarilloPrefab, position, rotation);
                    break;
                case 3:
                    Instantiate(globoVerdePrefab, position, rotation);
                    break;
                case 4:
                    Instantiate(globoAzulPrefab, position, rotation);
                    break;
            }
            
        }
    }
}
