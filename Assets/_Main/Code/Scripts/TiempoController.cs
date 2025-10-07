using UnityEngine;

public class TiempoController : MonoBehaviour
{
    public float cantidad = 10f; // Segundos que suma
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.SumarTiempo(10);
            Destroy(gameObject);
        }
    }
}
