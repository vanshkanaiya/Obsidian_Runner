using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuAndQuit : MonoBehaviour
{
    int maxLevel;
    void Start()
    {
        maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
    }

    public void playGame() {
        SceneManager.LoadScene("level" + maxLevel);
    }

    public void quitGame() {
        Debug.Log("Game quit");
        Application.Quit();
    }

    public void selectLevel() {
        SceneManager.LoadScene("Levels");        
    } 
}
