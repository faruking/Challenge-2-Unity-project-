using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;

 
    // Start is called before the first frame update
    void Start(){
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  
    }

    private float spawnPosX = 10;
    private float spawnPosZ = 20;

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX,spawnPosX),0,spawnPosZ);
        Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }
}
