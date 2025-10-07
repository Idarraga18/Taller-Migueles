using UnityEngine;

public class vidasController : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.vida++;
            Destroy(gameObject);
        }
    }
}
