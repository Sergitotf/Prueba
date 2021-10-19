using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadoraVelocidad : MonoBehaviour
{

    // Velocidad = distancia / tiempo
    float Velocidad(float distancia, float tiempo)
    {
        float v = distancia / tiempo;
        return v;
    }
    float Distancia(float velocidad, float tiempo)
    {
        float d = velocidad * tiempo;
        return d;
    }
    float Tiempo(float distancia, float velocidad)
    {
        float t = distancia / velocidad;
        return t;
    }
    void Start()
    {
        Debug.Log("Va a = " + Velocidad(10.5f, 20.0f) + "km/h");

        Debug.Log("Recorre = " + Distancia(10.5f, 20.0f) + "km");

        Debug.Log("Tarda = " + Tiempo(10.5f, 20.0f) + "h");

    }
   
    // Update is called once per frame
    void Update()
    {
         


    }
}
