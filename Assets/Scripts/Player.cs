﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int movementSpeed = 10; // movement speed
    public Vector2 jumpHeight = new Vector2(0, 25); // jump attributes
    public int availableJumps = 2; // No. jumps you can make. (Double Jumps)
    private bool allowCrouch = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && (availableJumps > 0)) {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            availableJumps--; // decrease possible jumps
            allowCrouch = true;
        }

        // Move down
        if (Input.GetKeyDown(KeyCode.S)) {
             GetComponent<Rigidbody2D>().AddForce(-jumpHeight, ForceMode2D.Impulse);
            allowCrouch = false;
        }

        // Move left
        if (Input.GetKey(KeyCode.A) && (transform.position.x >= -11.75f)) {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed, Space.World);
        }

        // Move right
        if (Input.GetKey(KeyCode.D) && (transform.position.x <= 11.8f)) {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed, Space.World);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // reset double jump when you hit the ground
        if ((collision.gameObject.tag == "Ground")) {
            availableJumps = 2;
            allowCrouch = true;
        }
    }

}
