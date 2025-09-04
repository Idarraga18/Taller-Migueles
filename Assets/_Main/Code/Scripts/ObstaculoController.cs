using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager != null && gameManager.ObtenerPuntos() >= 10)
        {
            Destroy(gameObject);
        }
    }
}
