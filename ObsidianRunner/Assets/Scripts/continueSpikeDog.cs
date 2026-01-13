using UnityEngine;
using UnityEngine.SceneManagement;

public class continueSpikeDog : MonoBehaviour
{
    public Transform LeftEnd;
    public Transform RightEnd;
    public float speed = 20f;

    private Vector2 target;

    void Start()
    {
        target = RightEnd.position;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
        );

        if (Vector2.Distance(transform.position, RightEnd.position) < 0.01f)
        {
            target = LeftEnd.position;   
        }
        else if (Vector2.Distance(transform.position, LeftEnd.position) < 0.01f)
        {
            target = RightEnd.position;  
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "spike-dog_10_conti_walk")
        {
            restatLevel();
        }
    }

    void restatLevel()
    {
        Debug.Log("endGame Scene Called?");
        SceneManager.LoadScene("endGame");
    }
}
