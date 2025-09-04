using UnityEngine;
using Unity.Mathematics;
using UnityEngine.SceneManagement;
using System.ComponentModel;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int vida = 15;
    [SerializeField]
    private int puntos = 0;
    [SerializeField]
    private float tiempoMaximo = 60f;

    private float tiempoRestante;

    private void Start()
    {
        tiempoRestante = tiempoMaximo;
    }

    private void Update()
    {
        tiempoRestante -= Time.deltaTime;
        
            if (tiempoRestante <= 0)
        {
            tiempoRestante = 0;
            SceneManager.LoadScene("taller");
        }

    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
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

    public void SumarVida(int cantidad)
    {
        vida += cantidad;
    }

    public float ObtenerTiempoRestante()
    { 
        return tiempoRestante;
    }

    public void AgregarTiempo(float segundos)
    {
        tiempoRestante += segundos;
    }
}
