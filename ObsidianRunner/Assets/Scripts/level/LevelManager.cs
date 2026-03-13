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
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Singleton reference
    public static LevelManager Instance;

    // Drag your 4 prefabs here in Inspector
    public List<GameObject> Levels;

    private int currentLevelIndex = 0;
    private GameObject currentLevel;

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
        LoadLevel(currentLevelIndex);
    }

    void LoadLevel(int index)
    {
        Debug.Log("Loading Level: " + index);
        currentLevel = Instantiate(Levels[index]);
    }

    public void LoadNextLevel()
    {
        if (currentLevel != null)
        {
            Destroy(currentLevel);
        }

        currentLevelIndex++;

        if (currentLevelIndex < Levels.Count)
        {
            LoadLevel(currentLevelIndex);
        }
        else
        {
            Debug.Log("All Levels Completed!");
        }
    }
}