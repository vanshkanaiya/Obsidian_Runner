using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    int maxLevel;
    void Start()
    {
        maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
    }

    public void selectLevel(int levelId) {
        string levelName = "level" + levelId;
        SceneManager.LoadScene(levelName);
        PlayerPrefs.SetInt("maxLevel", levelId);
    }
}
