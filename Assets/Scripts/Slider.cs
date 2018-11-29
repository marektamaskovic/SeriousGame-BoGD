using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour {

    public double time2gen = 2.0f;
    public int obstacleSpeed = 5;
    public double frequency = 1.0f;
    public GameObject[] obstacles;
    public Transform obstacleSpawnPoint;
    public double killZone = -17.0f;

    // Use this for initialization
    void Start () {
            GenerateRandomChallenge();
    }

    // Update is called once per frame
    void Update () {

        //GenerateObjects
        if (time2gen <= 0.0f) {
            GenerateRandomChallenge();
        }
        else {
            time2gen -= Time.deltaTime * frequency;
        }

        GameObject obstacle;
        for (int i = 0; i < transform.childCount; i++) {
            obstacle = transform.GetChild(i).gameObject;
            ScrollChallenge(obstacle);
            if (obstacle.transform.position.x <= killZone) {
                Destroy(obstacle);
            }
        }
    }

    void GenerateRandomChallenge()
    {
        if (obstacles.Length <= 0) return;
        GameObject newChallenge = Instantiate(obstacles[Random.Range(0, obstacles.Length)], obstacleSpawnPoint.position, Quaternion.identity) as GameObject;
        if(newChallenge == null) {
            Debug.Log("Debug: newChallenge is a null object");
            return;
        }
        newChallenge.transform.parent = transform;
        time2gen = 1.0f;
    }

    void ScrollChallenge(GameObject obstacle)
    {
        obstacle.transform.Translate(Vector2.left * Time.deltaTime * obstacleSpeed);
    }
}
