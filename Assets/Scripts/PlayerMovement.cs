using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D myRigidBody2D;

    [SerializeField]
    private float speed = 7.7f;

    [SerializeField]
    private float jumpHeight = 6;

    private bool isOnGround;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }

    // Use this for initialization
    void Start ()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();


        //Debug.Log("Greetings. Code called from Start.");

        //teleport
        //transform.position = new Vector3(0,0,0);

        
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("Text called from Update");

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0.1f, 0, 0);

        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-0.1f, 0, 0);

        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(0, 0.1f, 0);

        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(0, -0.1f, 0);

        //}

        //if (Input.GetButton("Horizontal"))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}

        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("horizontal input: " + horizontalInput);

        

        myRigidBody2D.velocity = new Vector2(speed * horizontalInput, myRigidBody2D.velocity.y);

        //transform.Translate(speed * horizontalInput, 0, 0);



        if (Input.GetButtonDown("Jump") & isOnGround)
        {
            myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, jumpHeight);

            isOnGround = false;

            //transform.Translate(0, 6, 0);
        }
    }

    

}
