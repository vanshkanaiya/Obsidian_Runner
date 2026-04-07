using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class playerMovement : MonoBehaviour
{
    int maxLevel;
    const int MaxJumps = 2;
    bool wasGrounded;
    

    public Rigidbody2D rb;
    [SerializeField] float moveSpeed = 25f;
    [SerializeField]float JumpForce = 875f;


    public Transform player;
    public TextMeshProUGUI scoreText;

    private int jumpFlag = 0;

    public AudioSource audioSourcePlayer;
    public AudioClip audioClipJump;
    public AudioClip audioClipDeath;
    public AudioClip audioClipLevelComplete;


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

        if (Input.GetKeyDown(KeyCode.Space) && jumpFlag < MaxJumps) {
            rb.AddForce(Vector2.up * JumpForce);
            jumpFlag++;
            audioSourcePlayer.PlayOneShot(audioClipJump);
        }

        rb.velocity = new Vector2(moveX, rb.velocity.y);

        pauseLevel();
        quitLevel();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            Debug.Log("Enemy!!!");
            audioSourcePlayer.PlayOneShot(audioClipDeath);
            restatLevel();
        }

        if (col.tag == "End") {
            audioSourcePlayer.PlayOneShot(audioClipLevelComplete);
            nextLevel();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ResetJumpOnGroundContact(collision);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (IsGroundCollision(collision))
        {
            wasGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            wasGrounded = false;
        }
    }

    void ResetJumpOnGroundContact(Collision2D collision)
    {
        if (!IsGroundCollision(collision))
        {
            return;
        }

        if (!wasGrounded)
        {
            jumpFlag = 0;
        }

        wasGrounded = true;
    }

    bool IsGroundCollision(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Ground"))
        {
            return false;
        }

        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (contact.normal.y > 0.5f)
            {
                return true;
            }
        }

        return false;
    }

    void restatLevel()
    {
        LevelManager.Instance.restartLevelUI();
    }

    void nextLevel() {
        Debug.Log("Next Levl!!");
        LevelManager.Instance.levelComplateUI();
    }

    void quitLevel(){
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Menu");
        }
    }

    void pauseLevel() {
        if (Input.GetKey("p"))
        {
            LevelManager.Instance.pauseGame();
        }
    }


}
