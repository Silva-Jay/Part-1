using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    //cloud rigidbody
    Rigidbody2D cloud;

    //movement direction vector
    Vector2 movement = new Vector2(10, 0);
    // Start is called before the first frame update
    void Start()
    {
        //search for rigidbody component in gameobject
        cloud = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //move cloud from left to right
        cloud.MovePosition(cloud.position - movement * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //destroy cloud if hidden collider is hit
        Destroy(gameObject);
        Debug.Log("cloud has been destroyed!");
    }

}
