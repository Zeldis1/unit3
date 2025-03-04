using UnityEngine;
using UnityEngine.AI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(28, 0, 0);
    private float startDelay = 1.5f;
    private float spawnInterval = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObsticles", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()


    { 

    }

    // another line that'll spawn random object
    void SpawnObsticles()
    {
        int obstacleIndex = Random.Range(0, 2);
    Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
    }


}