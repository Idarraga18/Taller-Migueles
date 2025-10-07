using UnityEngine;
using UnityEngine.UI;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] private bool isPaused = false;
    [SerializeField] private GameObject panel;
    [SerializeField] private Sprite[] spritesCorazon; // [0] vacío, [1] medio, [2] lleno (por ejemplo)
    [SerializeField] private Image[] imCorazones;     // Array de imágenes de corazones en la UI
    [SerializeField] private Color conllave;
    [SerializeField] private Color sinllave;
    [SerializeField] private Image imLlave;

    void Update()
    {
        // Detectar tecla Escape para pausar o reanudar
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                Pause();
        }
    }

    void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    void ResumeGame()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void CambiarLlave(bool tieneLlave)
    {
        imLlave.color = tieneLlave ? conllave : sinllave;
    }

    
    public void ActualizarUIVida(int vidaActual)
    {
        if (imCorazones == null || imCorazones.Length == 0)
        {
            Debug.LogError("No hay imágenes de corazones asignadas en el inspector.");
            return;
        }

        // Recorremos todos los corazones y actualizamos su sprite
        for (int i = 0; i < imCorazones.Length; i++)
        {
            if (i < vidaActual)
            {
                // Corazón lleno
                imCorazones[i].sprite = spritesCorazon[2];
            }
            else
            {
                // Corazón vacío
                imCorazones[i].sprite = spritesCorazon[0];
            }
        }
    }
}
