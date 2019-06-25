using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody2D RB2D;
    private Canvas canvas;
    private float x;
    private float y;
    [SerializeField]
    private int valor;
    // Start is called before the first frame update
    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();//pega o componente rigidbody
        canvas = FindObjectOfType<Canvas>();

        Vector2 posicao = new Vector2(Random.Range(canvas.GetComponent<RectTransform>().rect.xMin + 30, canvas.GetComponent<RectTransform>().rect.xMax - 30), Random.Range(canvas.GetComponent<RectTransform>().rect.yMin + 25, canvas.GetComponent<RectTransform>().rect.yMax - 25)); // gera uma posição aleatoria na tela para o eixo X E Y(de acordo com o minimo e maximo)         RB2D.position = posicao;
        this.GetComponent<RectTransform>().anchoredPosition = posicao;
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    void OnTriggerStay2D(Collider2D outro)
    {
        //chama o metodo ao colidir com um objeto
        if (outro.tag == "Letra" || outro.tag == "LetraCentral")
        {
            Vector2 posicao = new Vector2(Random.Range(canvas.GetComponent<RectTransform>().rect.xMin + 30, canvas.GetComponent<RectTransform>().rect.xMax - 30), Random.Range(canvas.GetComponent<RectTransform>().rect.yMin + 25, canvas.GetComponent<RectTransform>().rect.yMax - 25)); // gera uma posição aleatoria na tela para o eixo X E Y(de acordo com o minimo e maximo)         RB2D.position = posicao;
            this.GetComponent<RectTransform>().anchoredPosition = posicao;
        }
    }
}
