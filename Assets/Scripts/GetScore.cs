using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetScore : MonoBehaviour {

    int points;
    public Text pointsObject;

    // Use this for initialization
    void Start () {
        points = Points.points;
        pointsObject.text = points.ToString();
        Destroy(GameObject.Find("Canvas"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
