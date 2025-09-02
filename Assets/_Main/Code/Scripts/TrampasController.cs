using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SearchService;
public class TrampasController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")


        {
            gameManager.RestarVida(1);
        }
        
    }

}
