using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
    public GameObject pantalla1;
    public GameObject pantalla2;
    public GameObject pantalla3;
    public GameObject pantalla4;
    public GameObject pantalla5;
    public GameObject pantalla6;
    public float contador;
    public float cuentaAtras = 18f;

        void Start() 
    { //Bucle entre pantallas, reinicia el contador.
        contador = 0f;
        pantalla1.SetActive(true);
        pantalla2.SetActive(false);
        pantalla3.SetActive(false); 
    }

    void Update()
    {   //Contador de tiempo mientras el juego esté en funcionamiento
        contador += Time.deltaTime;
        /* No vuelve a la primera pantalla 
        if (contador >= 36f)
        {
            pantalla1.SetActive(false);
            pantalla2.SetActive(false);
            pantalla3.SetActive(true);
        }
       */

        //Presionar tecla espacio para saltar pantallas.
        if (Input.GetKeyUp(KeyCode.Space) && pantalla3.gameObject.activeSelf == false)
        {
            pantalla1.SetActive(false);
            pantalla2.SetActive(true);
        }
        //Cuenta atrás para el salto de pantalla, si llega a cuentaAtras, salta a pantalla2.
        if (contador >= cuentaAtras)
        {
            pantalla1.SetActive(false);
            pantalla2.SetActive(true);
        }
      
        /* Preguntar por volver de la tercera pantalla
        else 
        {
            pantalla1.SetActive(false);
            pantalla2.SetActive(false);
            pantalla3.SetActive(true);
        }*/
        //Saltar la ultima pantalla presionando espacio
        if (pantalla2.gameObject.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            pantalla2.SetActive(false);
            pantalla3.SetActive(true);
        } 
    }
 }

