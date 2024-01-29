using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilvaPlayer : MonoBehaviour
{
    //movement direction vector
    Vector2 movement;

    //silva's or the player's rigidbody
    Rigidbody2D silva;
    public float force = 50f;

    // Start is called before the first frame update
    void Start()
    {
        //search for rigidbody component in gameobject
        silva = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //get movement axis from key inputs- force increments as though on an icy sidewalk
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        if (silva.velocity.magnitude < 20)
        {
            //add force to player if the player's velocity magnitude is less than 20
            silva.AddForce(movement * force * Time.deltaTime * 2);
        }
    }
}
