using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI completText;
    public int CurrentScore;

    private void OnEnable()
    {
        StaticVars.PlayerSpawn += OnPlayerSpawn;
    }

    private void OnDisable()
    {
        StaticVars.PlayerSpawn -= OnPlayerSpawn;
    }

    void OnPlayerSpawn(Transform t)
    {
        player = t;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;

        scoreText.text = player.position.x.ToString("0");
        //if (CurrentScore < (int)player.position.x)
        //{
            CurrentScore = (int)player.position.x;
            restartText.text = CurrentScore.ToString();
            completText.text = CurrentScore.ToString();
        //}
    }
}
