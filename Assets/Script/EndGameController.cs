using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.GetComponent<playerController>() != null)
        {

            Debug.Log("GAME OVER");

        }


    }
}
