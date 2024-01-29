using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    public GameObject cloud;
    public float spawnTime = 5;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(cloud, transform.position, transform.rotation);
            timer = 0f;
        }
    }
}
