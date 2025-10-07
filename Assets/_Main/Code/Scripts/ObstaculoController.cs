using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    private GameManager gameManager;
    public int puntonnecesarios = 10;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager != null && gameManager.puntos >= puntonnecesarios)
        {
            Destroy(gameObject);
        }
    }
}
