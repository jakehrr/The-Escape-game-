using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPos;

    private GameObject player;
    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SpawnEnemy", startDelay, repeatRate);
    }

    void SpawnEnemy()
    { 
        Instantiate(enemyPrefab, spawnPos.position, enemyPrefab.transform.rotation);
    }
}
