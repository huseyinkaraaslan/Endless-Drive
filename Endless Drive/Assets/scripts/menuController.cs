using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public GameObject playScreen,mainScreen;
    string sceneName;      // for get active scene name

    public void Start()
    {
        mainScreen.SetActive(true);
        playScreen.SetActive(false);
    }
    public void play()
    {
        playScreen.SetActive(true);
        mainScreen.SetActive(false);
        
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void back2Menu()
    {
        sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "desertRoad" || sceneName == "cityRoad")
        {
            SceneManager.LoadScene("menu");
        }
        playScreen.SetActive(false);
        mainScreen.SetActive(true);
    }
    public void startDesertMap()
    {
        SceneManager.LoadScene("desertRoad");
    }

    public void startCityMap()
    {
        SceneManager.LoadScene("cityRoad");
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
