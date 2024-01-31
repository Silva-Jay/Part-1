using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawnScript : MonoBehaviour
{
    //current player's score   
    float score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //teleport snowflake to another part of the map upon collision
        transform.position = new Vector3(Random.Range(-11, 11), Random.Range(-4, 1), 0);
        //add 1 to the player's score and display it in the debug log
        score += 1;
        Debug.Log("Your score is " + score + "!");
    }

}
