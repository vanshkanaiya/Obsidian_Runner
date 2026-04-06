using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementDesable : MonoBehaviour
{
    //public static playerMovementDesable Instance;

    public playerMovement playerMovement;

    //private void Awake()
    //{
    //    // Singleton setup
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GetComponent<playerMovement>().enabled = false;
        }
        if (collision.tag == "End")
        {
            GetComponent<playerMovement>().enabled = false;
        }
    }
    private void Update()
    {
        if (Input.GetKey("p"))
        {
            try
            {
                GetComponent<playerMovement>().enabled = false;
                LevelManager.Instance.pauseGame();
            } catch {
                Debug.Log("Error..!");
            }
        }
    }

    //public void playerMovementEnable()
    //{
    //    GetComponent<playerMovement>().enabled = true;
    //}
}
