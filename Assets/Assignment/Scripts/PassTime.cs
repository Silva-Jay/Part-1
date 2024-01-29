using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTime : MonoBehaviour
{
    //public gameobject to store sky
    public GameObject sky;
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
        //hide afternoon sky if trigger is collided with
        sky.SetActive(false);
    }
}
