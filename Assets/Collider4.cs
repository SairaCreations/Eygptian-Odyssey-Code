using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider4 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 4");
        }
    }
}

