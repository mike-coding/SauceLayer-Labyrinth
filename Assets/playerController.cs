using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    float Horizontal;
    float Vertical;
    Rigidbody2D body;
    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");


        //TEST COMMENT
    }

    void FixedUpdate()
    {
        MoveDirection();
    }

    void MoveDirection()
    {

        float moveLimiter = 0.75f;
        if (Horizontal != 0 && Vertical != 0)
        {
            Horizontal *= moveLimiter;
            Vertical *= moveLimiter;
        }

        //set body velocity
        body.velocity = new Vector2(Horizontal * MoveSpeed, Vertical * MoveSpeed);


    }
}
