using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] spritesCorazon;
    [SerializeField]
    private Image imagencorazones;


    public void Start()
    {
        
    }
    public void ActualizarVIdaUI(int vida)
    {
        if(imagencorazones!=null && vida >=0 && vida < spritesCorazon.Length)
        {
            imagencorazones.sprite = spritesCorazon[vida];
        }
    }
}
