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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb2b.AddForce(direccion * fuerzadesalto);
    }
}
