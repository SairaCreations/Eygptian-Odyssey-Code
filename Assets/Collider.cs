using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level 1");
     }
  }
}
//{
    //public void PlayGame()
   // {
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    //}

//}