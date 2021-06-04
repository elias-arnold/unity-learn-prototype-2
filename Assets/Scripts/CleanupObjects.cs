using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanupObjects : MonoBehaviour
{
    public bool triggersGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(transform.position.z) > 50)
        {
            Destroy(gameObject);
            if (triggersGameOver)
            {
                Debug.Log("Game Over");
            }
        }
        
        if (Math.Abs(transform.position.y) > 50)
        {
            Destroy(gameObject);
            if (triggersGameOver)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
