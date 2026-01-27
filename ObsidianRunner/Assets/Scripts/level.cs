using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public void selectLevel(int levelId) {
        string levelName = "level" + levelId;
        SceneManager.LoadScene(levelName);
    }
}
