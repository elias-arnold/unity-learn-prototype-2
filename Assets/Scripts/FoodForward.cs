using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodForward : MonoBehaviour
{
    public float speed = 40f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
        if (Math.Abs(transform.position.z) > 50)
        {
            Destroy(gameObject);
        }
        
        if (transform.position.z < -10)
        {
            Debug.Log("Game Over!");
        }
    }
}