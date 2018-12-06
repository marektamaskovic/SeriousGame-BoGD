using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{

    public Text pointsObject;
    public bool pointsChanged = true;
    public static int points = 0;
    public int gameOverSceneIndex;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
        points = 0;

        pointsObject = GameObject.Find("Canvas/Points").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update ()
	{
	    if (pointsChanged)
	    {
	        pointsObject.text = points.ToString();
	        pointsChanged = false;
            if (points >= 42)
            {
                gameOverSceneIndex = 2;
                Die();
            }
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

    public int GetPoints()
    {
        return points;
    }

    void Die()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(gameOverSceneIndex);
    }
}
