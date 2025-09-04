using UnityEngine;

public class NaranjaController : MonoBehaviour
{
    [SerializeField]
    private float tiempoExtra = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AgregarTiempo(tiempoExtra);
            }

            Destroy(gameObject);
        }
    }
}
