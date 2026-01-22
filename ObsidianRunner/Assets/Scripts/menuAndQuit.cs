using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuAndQuit : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene(1);
    }

    public void quitGame() {
        Debug.Log("Game quit");
        Application.Quit();
    }

    public void selectLevel() {
        SceneManager.LoadScene("Levels");
    } 
}
