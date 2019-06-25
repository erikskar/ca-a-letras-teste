using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPrincipal : MonoBehaviour
{

    public static Vector3 coordenada;
    // Use this for initialization
    void Start()
    {
        Coordenadas(Screen.width, Screen.height);
    }

    // Update is called once per frame
    void Update()
    {
        Coordenadas(Screen.width, Screen.height);
    }

    public void Coordenadas(int ValorX, int ValorY)
    {
        coordenada = Camera.main.ScreenToWorldPoint(new Vector3(ValorX, ValorY, 0));
    }
}
