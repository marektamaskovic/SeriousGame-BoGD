using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_one_up : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Vector3 a = new Vector3(transform.position.x, 0);
	    transform.position = a;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
