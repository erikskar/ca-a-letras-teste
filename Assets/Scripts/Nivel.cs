using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nivel : MonoBehaviour
{
    int nivel;
    public void TriggerNivel(int i)
    {

        GameObject textoNivel = GameObject.FindGameObjectWithTag("TextoNivel");
        switch (i)
        {
            default:
            case 0:
                textoNivel.GetComponent<Text>().text = "No  nivel Fácil cada carta possuira o sinal em LIBRAS e a letra do alfabeto correspondente. O seu objetivo é encontrar a carta Correspondente a carta central.";
                nivel = 1;
                break;
            case 1:
                textoNivel.GetComponent<Text>().text = "No  nivel Médio cada carta possuira somente o sinal em LIBRAS. O seu objetivo é encontrar a carta Correspondente a carta central.";
                nivel = 2;
                break;
            case 2:
                textoNivel.GetComponent<Text>().text = "No  nivel Díficil as cartas espalhadas possuirão o sinal em LIBRAS, já a carta central possuirá a letra do alfabeto.O seu objetivo é encontrar a carta Correspondente a carta central.";
                nivel = 3;
                break;
        }
    }
    public void iniciar()
    {
        GameObject textoNivel = GameObject.FindGameObjectWithTag("TextoNivel");
        switch (nivel)
        {
            default:
                textoNivel.GetComponent<Text>().text = "Selecione um Nivel antes de Iniciar.";
                break;
            case 0:
                textoNivel.GetComponent<Text>().text = "Selecione um Nivel antes de Iniciar.";
                break;
            case 1:
                SceneManager.LoadScene("JogoFacil");//inicia o jogo
                break;
            case 2:
                SceneManager.LoadScene("JogoMedio");//inicia o jogo
                break;
            case 3:
                SceneManager.LoadScene("JogoDificil");//inicia o jogo
                break;
        }
    }
}
