using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If multiply collide with Player destroy the object
        // and call score handlers. 
        if (collision.gameObject.CompareTag("Player")) {
            Destroy(transform.gameObject);
            Debug.Log("x2 point");
            GameObject.Find("Canvas").GetComponent<Points>().MultiplyChange();
        }
    }
}
