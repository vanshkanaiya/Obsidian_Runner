using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerMovement : MonoBehaviour
{
    int maxLevel;
    void Start()
    {
        maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
    }

    public Rigidbody2D rb;
    [SerializeField] float moveSpeed = 25f;
    [SerializeField]float JumpForce = 875f;


    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb.AddForce(Vector2.right * moveSpeed);
        }

        if (Input.GetKey("a") || Input.GetKey("left")) {
            rb.AddForce(Vector2.left * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * JumpForce);
        }

        showScore();
        quitLevel();


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            Debug.Log("Enemy!!!");
            restatLevel();
        }

        if (col.tag == "End") {
            nextLevel();
        }
    }

    void restatLevel()
    {
        Debug.Log("endGame Scene Called?");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void nextLevel() {
        Debug.Log("Next Levl!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("maxLevel", SceneManager.GetActiveScene().buildIndex + 1);
    }

    void quitLevel(){
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }

    void showScore() {
        scoreText.text = "0";
        scoreText.text = player.position.x.ToString("0");
    }
}
