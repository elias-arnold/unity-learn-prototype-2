using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> animalPrefabs;

    public int spanRangeX = 10;

    public int spanHeightZ = 15;

    private float spawnInterval = 2f;
    private float spawnDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnNewAnimal), spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnNewAnimal();
        }
    }

    void SpawnNewAnimal()
    {
        GameObject animal = animalPrefabs[Random.Range(0, animalPrefabs.Count)];
        Instantiate(animal, new Vector3(Random.Range(-spanRangeX, spanRangeX), 0, spanHeightZ),
            animal.transform.rotation);
    }
}