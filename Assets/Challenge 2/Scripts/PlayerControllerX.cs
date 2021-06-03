using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private Double lastUpdate = 0d;

    public float minDelay = 1f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.timeAsDouble - lastUpdate > minDelay)
        {
            lastUpdate = Time.timeAsDouble;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        
        Input.GetKey(KeyCode.UpArrow)
    }
}