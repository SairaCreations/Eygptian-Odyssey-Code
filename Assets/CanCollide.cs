using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Globals.gravityScale = - 0.01f;
            Globals.numFail = 0;
            SceneManager.LoadScene("LevelEnd 3");
        }
    }
}