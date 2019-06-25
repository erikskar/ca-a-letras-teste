using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letra : MonoBehaviour
{

    [SerializeField]
    private int valor;

    [SerializeField]
    private GameObject letraCentral;
    private GameObject controlador;
    // Start is called before the first frame update
    void Start()
    {

        controlador = GameObject.FindGameObjectWithTag("Controlador");

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void ClicaCarta()
    {
        controlador.GetComponent<Controlador>().AumentaTextTentativas();
        if (this.valor == letraCentral.GetComponent<LetraCentral>().valorCarta)
        {
            controlador.GetComponent<Controlador>().AumentaTextAcertos();
            letraCentral.GetComponent<LetraCentral>().acertados.Add(this.valor);

            letraCentral.GetComponent<LetraCentral>().SetaCarta();
            Destroy(this.gameObject);
        }
        else
        {
            letraCentral.GetComponent<LetraCentral>().SetaCartaErro();
        }

    }


}
