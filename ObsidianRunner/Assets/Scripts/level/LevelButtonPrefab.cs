using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonPrefab : MonoBehaviour
{
    public int LevelNumber;
    public TMP_Text Level_Txt;

    public void OnLevelBtn_Clicked()
    {
        Debug.Log("levelbtn");
        LevelData.Instance.CurrentLevel = LevelNumber;
        SceneManager.LoadScene("Level");
    }

    private void OnValidate()
    {
        Level_Txt.text = LevelNumber.ToString();
        gameObject.name = $"Level-{LevelNumber}";
    }

}
