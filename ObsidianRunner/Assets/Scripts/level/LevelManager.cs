using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> Levels;
    private void Start()
    {
        var levelIndex = 0;
        Instantiate(Levels[levelIndex]);
    }
}
