using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : GenericSingleton<LevelData>
{
    public int CurrentLevel;
    public int TotalLevels;

    public string TotalLevelUnlockedPref = "TotalLevelUnlocked";
    public int TotalLevelUnlocked => PlayerPrefs.GetInt(TotalLevelUnlockedPref, 0);

    public void CheckLevelUnlock()
    {
        if (CurrentLevel - 1 == TotalLevelUnlocked && CurrentLevel != TotalLevels)
            PlayerPrefs.SetInt(TotalLevelUnlockedPref, CurrentLevel);
    }
}
