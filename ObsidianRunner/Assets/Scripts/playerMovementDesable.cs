using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementDesable : MonoBehaviour
{
    public playerMovement playerMovement;
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
            GetComponent<playerMovement>().enabled = false;
            LevelManager.Instance.pauseGame();
        }
    }
}
