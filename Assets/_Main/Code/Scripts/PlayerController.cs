using UnityEngine;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2b;
    [SerializeField]
    private Vector2 direccion;
    [SerializeField]
    private float fuerzadesalto = 100f;
    [SerializeField]
    private float velocidadX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2b.AddForce(direccion * fuerzadesalto);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2b.AddForce(Vector2.left * velocidadX);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2b.AddForce(Vector2.right * velocidadX);
        }

    }
    
}
