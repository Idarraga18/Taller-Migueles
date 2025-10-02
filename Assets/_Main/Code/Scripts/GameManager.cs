using UnityEngine;
using Unity.Mathematics;
using UnityEngine.SceneManagement;
using System.ComponentModel;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int vida = 15;
    [SerializeField]
    private int puntos = 0;
    [SerializeField]
    private float tiempoMaximo = 125f;
    [SerializeField]
    private float tiempoRestante;
    [SerializeField]
    private GameObject obstaculo;
    [SerializeField]
    private bool tieneLlave = false;
    [SerializeField]
    private TextMeshProUGUI vidaUI;
    [SerializeField]
    private TextMeshProUGUI puntosUI;
    [SerializeField]
    private TextMeshProUGUI tiempoUI;
    [SerializeField]
    private TextMeshProUGUI tienellaveUI;

  

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
            SceneManager.LoadScene("Perdiste");
       
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
        ActualizaUI();
    }
    public void RestarVida(int cantidad)

    {
        if (vida <= 0)
        {
            SceneManager.LoadScene("Perdiste");
        }
        else
        {
            vida -= cantidad;
          
        }
        ActualizaUI();
    }

    public void SumarVida(int cantidad)
    {
        vida += cantidad;
        ActualizaUI();
         
    }

    public float ObtenerTiempoRestante()
    {
        return tiempoRestante;
    }

    public void AgregarTiempo(float segundos)
    {
        tiempoRestante += segundos;
        ActualizaUI();
    }
    public void RecogerLlave()
    {
        tieneLlave = true;
        ActualizaUI();

    }
    public int ObtenerPuntos()
    {
        return puntos;
    }

    private void ActualizaUI()
    {
        if (puntosUI != null) puntosUI.text = "puntos:   " + puntos;
        if (vidaUI != null) vidaUI.text = "vida:   " + vida;
        if (tiempoUI != null) tiempoUI.text = "tiempo:   " + math.ceil(tiempoRestante);
        if (tienellaveUI != null) tienellaveUI.text = "tienellave:   " + tieneLlave;

    }
    public void EstadoDelJuego(string estado)
    {
        switch (estado)
        {
            case "Pause":

                Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
                break;
                
            case "Ganaste":
                SceneManager.LoadScene("Ganaste");
                break;
            case "Perdiste":
                SceneManager.LoadScene(2);
                break;
            case "Salir":
                Application.Quit();
                break;
        }
        

        }
    

}
