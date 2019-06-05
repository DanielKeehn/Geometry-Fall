using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class creates a random shape and spawns it into the game 

public class SpawnShape : MonoBehaviour 

    //These variables deal with the process of spawning shape at a certain time
    float startTime;
    bool spawnObject;

    //Variables that deal with shapes spawning directly by player 
    float startTimePlayer;
    bool spawnPlayerObject;
    
    
    //These are all the materials for the obstacles that spawn in and a list that stores them
    Material[] matList;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;

    //This variable references an Object that chooses the spawn point of each obstacle
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public Transform playerPosition;

    //These are the three random shapes an obstacle can be
    GameObject[] shapes;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cyllinder1;
    public GameObject cyllinder2;
    public GameObject cyllinder3;
    public GameObject cyllinder4;

    //creates timer and adds shapes and mats to lists
    private void Start() {
        startTime = Time.time;
        spawnObject = false;
        startTimePlayer = Time.time;
        spawnPlayerObject = false;

        shapes = new GameObject[8];
        shapes[0] = cube1;
        shapes[1] = cube2;
        shapes[2] = cube3;
        shapes[3] = cube4;
        shapes[4] = cyllinder1;
        shapes[5] = cyllinder2;
        shapes[6] = cyllinder3;
        shapes[7] = cyllinder4;
        cube1.tag = "Obstacle";
        cube2.tag = "Obstacle";
        cube3.tag = "Obstacle";
        cube4.tag = "Obstacle";
        cyllinder1.tag = "Obstacle";
        cyllinder2.tag = "Obstacle";
        cyllinder3.tag = "Obstacle";
        cyllinder4.tag = "Obstacle";

        matList = new Material[6];
        matList[0] = mat1;
        matList[1] = mat2;
        matList[2] = mat3;
        matList[3] = mat4;
        matList[4] = mat5;
        matList[5] = mat6;

    }

    private void Update() {
    //Enacts if two seconds has passed
    if (Time.time - startTime > 2)
    {
        spawnObject = true;
        spawnPoint.position = new Vector2(Random.Range(-2, 6), 10);
    }
        if (Time.time - startTimePlayer > 5)
        {
            spawnPlayerObject = true;
        }
        //after method above is run, this runs and actually spawns the obstacle
        if (spawnObject) {
            int randomNumforShape = Random.Range(0, 8);
            GameObject fallingObject = 
                Instantiate(shapes[randomNumforShape], spawnPoint.position, spawnPoint.rotation) as GameObject;
            int randomNumforMat = Random.Range(0, 6);
            fallingObject.GetComponent<Renderer>().material = matList[randomNumforMat];
            spawnObject = false;
            startTime = Time.time;
        }
    }

