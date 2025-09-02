using UnityEngine;
using Unity.Mathematics;
using UnityEngine.SceneManagement;
using System.ComponentModel;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int vida = 10;
    [SerializeField]
    private int puntos;
    [SerializeField]
    private float tiempo = 60f;
    [SerializeField]
    private int tiempoEntero;


    // Update is called once per frame
    void Update()
    {
        if (tiempo > 0f)
        {
            tiempo -= Time.deltaTime;
            tiempoEntero = (int)tiempo;

            Debug.Log("tiempo restante:" + Mathf.CeilToInt(tiempo));

        }
        if (tiempoEntero > 0f)
            SceneManager.LoadScene("Taller");

    }
   public void SumarPuntos(int cantidad)
    {
        puntos = cantidad;
    }

    public void RestarVida(int cantidad)

    {
        if (vida <= 0)
        {
            SceneManager.LoadScene("taller");
        }
        else
        {
            vida -= cantidad;
        }
    }

}
