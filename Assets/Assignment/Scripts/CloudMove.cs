using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    Rigidbody2D cloud;
    Vector2 movement = new Vector2(10, 0);
    // Start is called before the first frame update
    void Start()
    {
        cloud = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        cloud.MovePosition(cloud.position - movement * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log("cloud has been destroyed!");
    }

}
