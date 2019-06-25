using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GerarObjetos
{
    public GameObject prefab;
    public int contador;
    public float instanciarEsperar;
    public float tempo;
}

public class InstanciarObjetos : MonoBehaviour
{

    public GerarObjetos objetos;

    // Use this for initialization
    void Start()
    {

        StartCoroutine(Instanciar());// chama a função que instancia os objetos

    }

    IEnumerator Instanciar()
    {
        while (true)//loop para continuar gerando os objetos
        {
            for (int i = 0; i < objetos.contador; i++)//gera a quantidade de objetos definida no metodo
            {
                Vector2 posicao = new Vector2(Random.Range(-CameraPrincipal.coordenada.x, CameraPrincipal.coordenada.x), CameraPrincipal.coordenada.y); // gera uma posição aleatoria na tela para o eixo x(de acordo com o minimo e maximo) e para  y pega o limite superior

                Instantiate(objetos.prefab, posicao, objetos.prefab.transform.rotation);//instancia os objetos

                yield return new WaitForSeconds(objetos.instanciarEsperar);//faz uma pausa no fluxo 
            }
            yield return new WaitForSeconds(objetos.tempo);//faz uma nova pausa no fluxo
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
