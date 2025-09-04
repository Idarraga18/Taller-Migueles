using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager gameManager = FindObjectOfType<GameManager>();

            Debug.Log("llegue pues perra");
            SceneManager.LoadScene("Ganaste");
        }
    }
}
