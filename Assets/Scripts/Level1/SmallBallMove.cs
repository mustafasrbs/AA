using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SmallBallMove : MonoBehaviour
{
    Rigidbody2D rb;
    float speedLine = 140f;
    public bool move;
    public GameObject GameManagerScript;
    public GameObject panel;
    public GameObject bigBallScript;
    public int level;



    void Start()
    {
        GameManagerScript = GameObject.FindGameObjectWithTag("Manager");
        panel = GameObject.FindGameObjectWithTag("red");
        bigBallScript = GameObject.FindGameObjectWithTag("BigBall");
        rb = GetComponent<Rigidbody2D>();
        level = PlayerPrefs.GetInt("level");

    }


    void Update()
    {
        if (move == false)
        {

            rb.MovePosition(rb.position + Vector2.up * speedLine * Time.deltaTime);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SmallBall")
        {
            GameManagerScript.GetComponent<GameManager>().GameOver();


        }
        else if (collision.gameObject.tag == "BigBall")
        {
            transform.SetParent(collision.transform);
            move = true;
            if (bigBallScript.transform.childCount == 10 && level == 1)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel2();
            }
            if (bigBallScript.transform.childCount == 15 && level == 2)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel3();
            }
            if (bigBallScript.transform.childCount == 18 && level == 3)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel4();
            }
            if (bigBallScript.transform.childCount == 14 && level == 4)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel5();
            }
            if (bigBallScript.transform.childCount == 16 && level == 5)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel6();
            }
            if (bigBallScript.transform.childCount == 16 && level == 6)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel7();
            }
            if (bigBallScript.transform.childCount == 18 && level == 7)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel8();
            }
            if (bigBallScript.transform.childCount == 22 && level == 8)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel9();
            }
            if (bigBallScript.transform.childCount ==25  && level == 9)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel10();

            }
            if (bigBallScript.transform.childCount == 25 && level == 10)
            {
                GameManagerScript.GetComponent<GameManager>().NextLevel11();

            }

        }


    }
}
