using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SmallBallSpawn;
    public GameObject BigBall;
    public GameObject Panel;
    public GameObject greenPanel;
    

    public void GameOver()
    {
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        Panel.gameObject.SetActive(true);



    }
    public void NextLevel2()
    {
        Debug.Log("level2");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);

    }
    public void NextLevel3()
    {
        Debug.Log("level3");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel4()
    {
        Debug.Log("Level4");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);

    }
    public void NextLevel5()
    {
        Debug.Log("Level5");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel6()
    {
        Debug.Log("Level6");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel7()
    {
        Debug.Log("Level7");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel8()
    {
        Debug.Log("Level8");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel9()
    {
        Debug.Log("Level9");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel10()
    {
        Debug.Log("Level10");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }
    public void NextLevel11()
    {
        Debug.Log("Level11");
        SmallBallSpawn.GetComponent<Spawner>().enabled = false;
        BigBall.GetComponent<BigBallMove>().enabled = false;
        greenPanel.SetActive(true);
    }



}
