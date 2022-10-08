using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigBallMove : MonoBehaviour
{
    private float speed;
    public GameObject BigBall;
    public SmallBallMove smallBallMoveScript;
   
   
    void Start()
    {
        speed = 100f;
        
    }

    
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);

      
    }
   
}
