using UnityEngine;
using UnityEngine.SceneManagement;

public class menuAndQuit : MonoBehaviour
{
    public GameObject levelCanvas;
    public GameObject menuCanvas;
    public GameObject settingCanvas;

    int maxLevel;

    void Start()
    {
        maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
    }

    //public void playGame() {
    //    SceneManager.LoadScene("Level");
    //}
    public void playGame()
    {
        int savedLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
        LevelData.Instance.CurrentLevel = 1;
        SceneManager.LoadScene("Level");
    }

    public void quitGame() {
        Debug.Log("Game quit");
        Application.Quit();
    }

    public void selectLevel() {
        menuCanvas.SetActive(false);
        levelCanvas.SetActive(true);
        Debug.Log("Select Level..!");
    }

    public void backHome() {
        menuCanvas.SetActive(true);
        levelCanvas.SetActive(false);
        Debug.Log("Back Clicked..!!");
    }

    public void settingCanvasCall() {
        menuCanvas.SetActive(false);
        settingCanvas.SetActive(true);
    }

    public void backHomeFromSetting()
    {
        menuCanvas.SetActive(true);
        settingCanvas.SetActive(false);
    }
}
