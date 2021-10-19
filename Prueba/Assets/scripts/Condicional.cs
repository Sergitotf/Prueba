using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional : MonoBehaviour
{
    public int edad = 20;
        
    // No funciona!! preguntar por el orden
    void Start()
    {
        
        if (edad >= 65)
        {
            Debug.Log("Si es mayor de 65 está jubilado");
        }
        else if(edad > 18 && edad < 65)
        {
            Debug.Log("Si es mayor de 18 y menor 65 puede votar");
        }
        else if(edad < 18)
        {
            Debug.Log("Es menor de edad, no puede votar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
