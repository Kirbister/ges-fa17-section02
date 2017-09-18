using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
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

        float speed = 0.2f;

        transform.Translate(speed * horizontalInput, 0, 0);

        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 6, 0);
        }
    }


}
