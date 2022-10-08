using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnBall;
    void Start()
    {
        
    }

    void Update()
    {   // android controller
        for (var i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                spawnSmallBall();
            }
        }
        // pc controller
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnSmallBall();
        }
    }
    void spawnSmallBall()
    {
        Instantiate(spawnBall, transform.position, transform.rotation);
    }
}
