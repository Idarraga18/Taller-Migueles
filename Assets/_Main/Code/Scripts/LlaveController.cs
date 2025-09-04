using UnityEngine;

public class LlaveController : MonoBehaviour
{
    public bool llaveRecogida = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<GameManager>().RecogerLlave();

            Debug.Log("ya cogi esa perra");
                  Destroy(gameObject);
        }
    }
}
