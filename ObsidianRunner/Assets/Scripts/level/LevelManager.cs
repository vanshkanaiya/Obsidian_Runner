using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> Levels;
    private void Start()
    {
        var levelIndex = LevelData.Instance.CurrentLevel - 1;
        Instantiate(Levels[levelIndex]);
    }
}
