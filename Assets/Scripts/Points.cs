using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    public Text pointsObject;
    public bool pointsChanged = true;

    public int points = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (pointsChanged)
	    {
	        pointsObject.text = points.ToString();
	        pointsChanged = false;
	    }
    }

    public void PlusChange()
    {
        points++;
        pointsChanged = true;
    }
     
    public void MinusChange()
    {
        if (points > 0)
        {
            points--;
            pointsChanged = true;
        }
    }

    public void MultiplyChange()
    {
        points = points * 2;
        pointsChanged = true;
    }

    public void DivChange()
    {
        points = points / 2;
        pointsChanged = true;
    }
}
