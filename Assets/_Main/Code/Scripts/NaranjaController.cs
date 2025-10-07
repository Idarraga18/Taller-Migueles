using UnityEngine;

public class AzulController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.SumarVida();
            Destroy(this.gameObject);
        }
    }
}
