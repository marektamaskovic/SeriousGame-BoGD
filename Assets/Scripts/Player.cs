using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int movementSpeed = 10; // movement speed
    public Vector2 jumpHeight = new Vector2(0, 25); // jump attributes
    private bool allowJump = true; 
    public int availableJumps = 2; // No. jumps you can make. (Double Jumps)

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && (availableJumps > 0)) {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
            availableJumps--; // decrease possible jumps
        }

        // Move down
        if (Input.GetKeyDown(KeyCode.S)) {
             GetComponent<Rigidbody2D>().AddForce(-jumpHeight, ForceMode2D.Impulse);
        }

        // Move left
        if (Input.GetKey(KeyCode.A) && (transform.position.x >= -10.2f)) {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed, Space.World);
        }

        // Move right
        if (Input.GetKey(KeyCode.D) && (transform.position.x <= 10.2f)) {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed, Space.World);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.name == "Ground")) {
            availableJumps = 2;
        }
    }

}
