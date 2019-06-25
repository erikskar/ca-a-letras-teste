using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public Text textoTentativas;
    public Text textoAcertos;
    private int acertos = 0;
    private int tentativas = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentaTextAcertos()
    {
        acertos ++;
        textoAcertos.text = "Número de Acertos: " + acertos.ToString();
    }
    public void AumentaTextTentativas()
    {
        tentativas++;
        textoTentativas.text = "Número de Tentativas: " + tentativas.ToString();
    }
}
