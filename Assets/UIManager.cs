using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text tituloText;
    [SerializeField]
    private TMP_Text alertasText;

    [SerializeField]
    private TMP_InputField respuestaInput;

    [SerializeField]
    private Button enviarButton;

    [SerializeField]
    private int edad;


    private void Start()
    {
        tituloText.text = "Hola, introduce tu edad";
        alertasText.text = "";
        enviarButton.onClick.AddListener(FuncionDeBoton);
       


    }

    public void FuncionDeBoton()
    {
        edad = int.Parse(respuestaInput.textComponent.text);

        
    }

}
