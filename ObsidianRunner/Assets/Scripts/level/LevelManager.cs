//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class LevelManager : MonoBehaviour
//{
//    public List<GameObject> Levels;
//    private void Start()
//    {
//        var levelIndex = LevelData.Instance.CurrentLevel - 1;
//        Instantiate(Levels[levelIndex]);
//    }
//}


using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Singleton reference
    public static LevelManager Instance;

    // Drag your 4 prefabs here in Inspector
    public List<GameObject> Levels;

    private int currentLevelIndex = 0;
    private GameObject currentLevel;

    public GameObject gameUI;
    public GameObject scoreBoard;
    public GameObject restartUI;
    public GameObject pauseUI;
    public GameObject AllLevelComplateIU;

    public TextMeshProUGUI levelName;

    public playerMovement plyMov;

    private void Awake()
    {
        // Singleton setup
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentLevelIndex = LevelData.Instance.CurrentLevel - 1;
        LoadLevel(currentLevelIndex);

        plyMov = FindAnyObjectByType<playerMovement>();
    }

    void LoadLevel(int index)
    {
        Debug.Log("Loading Level: " + index);
        currentLevel = Instantiate(Levels[index]);
        levelName.text = Levels[index].name;
    }
    public void levelComplateUI() { 
        gameUI.SetActive(false);
        scoreBoard.SetActive(true);
        restartUI.SetActive(false);
    }
    public void restartLevelUI()
    {
        gameUI.SetActive(false);
        scoreBoard.SetActive(false);
        restartUI.SetActive(true);
    }
    public void LoadNextLevel()
    {
        if (currentLevel != null)
        {
            Destroy(currentLevel);
        }

        currentLevelIndex++;
        PlayerPrefs.SetInt("CurrentLevel", currentLevelIndex + 1);
        PlayerPrefs.Save();

        if (currentLevelIndex < Levels.Count)
        {
            gameUI.SetActive(true);
            scoreBoard.SetActive(false);
            restartUI.SetActive(false);
            LoadLevel(currentLevelIndex);
        }
        else
        {
            Debug.Log("All Levels Completed!");
            AllLevelComplateIU.SetActive(true);
            scoreBoard.SetActive(false);
        }
    }

    public void restartLevel()
    {
        if (currentLevel != null)
        {
            Destroy(currentLevel);
            Debug.Log("destroy");
        }
        gameUI.SetActive(true);
        scoreBoard.SetActive(false);
        restartUI.SetActive(false);

        LoadLevel(currentLevelIndex);
    }

    public void stopLevel()
    {
        SceneManager.LoadScene("Menu");
    }

    public void pauseGame() { 
        plyMov.enabled = false;
        pauseUI.SetActive(true);
    }

    public void resumeGame() {
        plyMov.enabled=true;
        pauseUI.SetActive(false);
    }

}