using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    //public gameobject to store cloud prefab
    public GameObject cloud;

    //spawn rate of clouds
    public float spawnTime = 5;

    //timer to detect if spawn rate has passed
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer that spawns cloud when hits spawnTime
        if (timer < spawnTime)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            //spawn cloud
            Instantiate(cloud, transform.position, transform.rotation);
            //reset timer
            timer = 0f;
        }
    }
}
