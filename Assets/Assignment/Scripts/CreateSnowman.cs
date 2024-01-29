using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSnowman : MonoBehaviour
{
    //public gameobject to store snowman sprite
    public GameObject snowman;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //display snowman when collided with collider
        snowman.SetActive(true);
    }
}
