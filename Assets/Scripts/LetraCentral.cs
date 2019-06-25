using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LetraCentral : MonoBehaviour
{
    public Sprite[] cartaCentral;
    public Sprite[] cartaCentralErro;
    [SerializeField]
    public int valorCarta;
    [SerializeField]
    public GameObject carta;
    public List<int> acertados;

    // Start is called before the first frame update
    void Start()
    {
        SetaCarta();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }

    }

    public void SetaCarta()
    {

        if (acertados.Count == 26)
        {
            //Time.time; // mostra o tempo desde que o jogo iniciou
            SceneManager.LoadScene("menu");//inicia o jogo

        }
        else
        {
            int x = Random.Range(0, cartaCentral.Length);

            while (acertados.Contains(x))
            {
                x = Random.Range(0, cartaCentral.Length);
            }
            carta.GetComponent<LetraCentral>().valorCarta = x;
            carta.GetComponent<Image>().sprite = cartaCentral[x];
        }
    }

    public void SetaCartaErro()
    {
        esperaErro();
    }


    public void esperaErro()
    {
        StartCoroutine(PausaErro());
    }
    IEnumerator PausaErro()
    {
        carta.GetComponent<Image>().sprite = cartaCentralErro[carta.GetComponent<LetraCentral>().valorCarta];
        yield return new WaitForSeconds(1);
        carta.GetComponent<Image>().sprite = cartaCentral[carta.GetComponent<LetraCentral>().valorCarta];


    }

}
