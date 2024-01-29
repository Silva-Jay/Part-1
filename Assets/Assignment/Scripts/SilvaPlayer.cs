using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilvaPlayer : MonoBehaviour
{

    Vector2 movement;
    Rigidbody2D silva;
    public float force = 50f;

    // Start is called before the first frame update
    void Start()
    {
        silva = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        if (silva.velocity.magnitude < 20)
        {
            silva.AddForce(movement * force * Time.deltaTime * 2);
        }
    }
}
