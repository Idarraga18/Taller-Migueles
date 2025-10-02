using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image[] spritesCorazon;
    

    private void Start()
    {
        
        for (int i = 0; i < 4; i++)
        {
            spritesCorazon[i].enabled = false;  
        }
        

    }

  
}
