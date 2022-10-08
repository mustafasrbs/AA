using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

           

public class MainMenuScript : MonoBehaviour
{
    SmallBallMove levelScript;
    public void startGame()
    {
        PlayerPrefs.SetInt("level", 1);
        SceneManager.LoadScene(1);
    }
    public void Oyna()
    {
        // PlayerPrefs.SetInt("level",1 );
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextButton()
    {
        PlayerPrefs.SetInt("level",2);
        SceneManager.LoadScene(2);
    }
    public void NextButton2()
    {   
        PlayerPrefs.SetInt("level", 2);
        SceneManager.LoadScene(2);
    }
    public void NextButton3()
    {
        PlayerPrefs.SetInt("level", 3);
        SceneManager.LoadScene(3);
    }
    public void NextButton4()
    {
        PlayerPrefs.SetInt("level", 4);
        SceneManager.LoadScene(4);
    }
    public void NextButton5()
    {
        PlayerPrefs.SetInt("level", 5);
        SceneManager.LoadScene(5);
    }
    public void NextButton6()
    {
        PlayerPrefs.SetInt("level", 6);
        SceneManager.LoadScene(6);
    }
    public void NextButton7()
    {
        PlayerPrefs.SetInt("level", 7);
        SceneManager.LoadScene(7);
    }
    public void NextButton8()
    {
        PlayerPrefs.SetInt("level", 8);
        SceneManager.LoadScene(8);
    }
    public void NextButton9()
    {
        PlayerPrefs.SetInt("level", 9);
        SceneManager.LoadScene(9);
    }
    public void NextButton10()
    {
        PlayerPrefs.SetInt("level", 10);
        SceneManager.LoadScene(10);
    }
    public void NextButton11()
    {
        PlayerPrefs.SetInt("level", 11);
        SceneManager.LoadScene(11);
    }



}
