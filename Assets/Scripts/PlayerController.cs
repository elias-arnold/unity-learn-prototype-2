using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 10f;

    public float xrange = 15;

    public GameObject projecttilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x <= -xrange && horizontalInput < 0)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= xrange && horizontalInput > 0)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);    
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projecttilePrefab, transform.position, projecttilePrefab.transform.rotation);
        }
        
        
    }
}
