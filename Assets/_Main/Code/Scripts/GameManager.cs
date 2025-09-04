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
    [SerializeField]
    private float tiempoRestante;
    [SerializeField]
    private GameObject obstaculo;
    [SerializeField]
    private bool tieneLlave = false;

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
        puntos++;
        if (puntos >= 10 && obstaculo != null)
        {
            Destroy(obstaculo);
            obstaculo = null;
        }
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
    public void RecogerLlave()
    {
        tieneLlave= true;

    }
    public int ObtenerPuntos()
    {
        return puntos;
    }
}
