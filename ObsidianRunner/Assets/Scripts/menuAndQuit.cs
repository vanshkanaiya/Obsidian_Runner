using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuAndQuit : MonoBehaviour
{
    public GameObject levelCanvas;
    public GameObject menuCanvas;

    int maxLevel;

    void Start()
    {
        maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
    }

    public void playGame() {
        SceneManager.LoadScene("Level");
    }

    public void quitGame() {
        Debug.Log("Game quit");
        Application.Quit();
    }

    public void selectLevel() {
        menuCanvas.SetActive(false);
        levelCanvas.SetActive(true);
    }

    public void backHome() {
        menuCanvas.SetActive(true);
        levelCanvas.SetActive(false);
    }
}
