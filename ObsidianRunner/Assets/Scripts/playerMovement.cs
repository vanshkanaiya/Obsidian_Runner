using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerMovement : MonoBehaviour
{
    int maxLevel;
    

    public Rigidbody2D rb;
    [SerializeField] float moveSpeed = 25f;
    [SerializeField]float JumpForce = 875f;


    public Transform player;
    public TextMeshProUGUI scoreText;

    private int jumpFlag = 0;


    void Start()
    {
        //maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
        Camera.main.gameObject.GetComponent<FollowPlayer>().player = transform;
        rb = GetComponent<Rigidbody2D>();
        StaticVars.PlayerSpawn?.Invoke(transform);
    }

    void Update()
    {
        float moveX = 0;
        if (Input.GetKey("d") || Input.GetKey("right")) {
            moveX = moveSpeed;
        }

        if (Input.GetKey("a") || Input.GetKey("left")) {
            moveX = -moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector2.up * JumpForce);
            jumpFlag++;

        }

        rb.velocity = new Vector2(moveX, rb.velocity.y);

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
            LevelManager.Instance.levelComplateUI();
        }
    }

    void restatLevel()
    {
        Debug.Log("endGame Scene Called?");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void nextLevel() {
        Debug.Log("Next Levl!!");
        //SceneManager.LoadScene("level");
        //LevelManager.Instance.LoadNextLevel();
    }

    void quitLevel(){
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }
}
