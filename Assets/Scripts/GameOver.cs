using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    int points;
    public Text pointsObject;
    public Text mainText;

    // Use this for initialization
    void Start () {

        points = Points.points;

        if (points == 42)
        {
            mainText.text = "You Won!";
        }
        else
        {
            mainText.text = "You Lost";
        }

        pointsObject.text = points.ToString();
        Destroy(GameObject.Find("Canvas"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
