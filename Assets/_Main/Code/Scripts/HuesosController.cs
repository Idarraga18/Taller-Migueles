using UnityEngine;

public class HuesosController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.SumarPuntos(0);
            Destroy(this.gameObject);
        }
    }
}