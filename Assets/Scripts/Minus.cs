﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If minus collide with Player destroy the object
        // and call score handlers. 
        if (collision.gameObject.CompareTag("Player")) {
            Destroy(transform.gameObject);
            Debug.Log("-1 point");
            GameObject.Find("Canvas").GetComponent<Points>().MinusChange();
        }
    }
}
