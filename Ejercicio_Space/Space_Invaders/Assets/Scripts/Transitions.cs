using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public GameObject pantalla1;
    public GameObject pantalla2;
    public GameObject pantalla3;
    public GameObject pantalla4;
    public GameObject pantalla5;
    public GameObject pantalla6;


    void Start()
    {
        LeanTween.scale(pantalla1, new Vector3(0f, 0f, 0f), 0f);
        LeanTween.scale(pantalla2, new Vector3(0f, 0f, 0f), 0f);
        LeanTween.scale(pantalla3, new Vector3(0f, 0f, 0f), 0f);
        LeanTween.scale(pantalla4, new Vector3(0f, 0f, 0f), 0f);
        LeanTween.scale(pantalla5, new Vector3(0f, 0f, 0f), 0f);
        LeanTween.scale(pantalla6, new Vector3(0f, 0f, 0f), 0f);


        //las pantallas empiezan minimizadas en 0 en las tres dimensiones
    }


    void Update()
    {
         if (pantalla1.gameObject.activeSelf == true)
        {
            LeanTween.scale(pantalla1, new Vector3(1f, 1f, 1f), 1.0f).setEaseOutBounce();
        }

        if (pantalla2.gameObject.activeSelf == true)
        {
            LeanTween.scale(pantalla2, new Vector3(1f, 1f, 1f), 1.0f).setEaseOutBounce();
        }

        if (pantalla3.gameObject.activeSelf == true)
        {
            LeanTween.scale(pantalla3, new Vector3(1f, 1f, 1f), 1f).setEaseOutBounce();
        }

        if (pantalla4.gameObject.activeSelf == true)
        {
            LeanTween.scale(pantalla4, new Vector3(1f, 1f, 1f), 1.0f).setEaseOutBounce();
        }

        if (pantalla5.gameObject.activeSelf == true)
        {
            LeanTween.scale(pantalla5, new Vector3(1f, 1f, 1f), 1f).setEaseOutBounce();
        }

        if (pantalla6.gameObject.activeSelf == true)
        {
            LeanTween.scale(pantalla6, new Vector3(1f, 1f, 1f), 1.0f).setEaseOutBounce();
        }


        //activa la transición entre pantallas


        if (pantalla1.gameObject.activeSelf == false)
        {
            LeanTween.scale(pantalla1, new Vector3(0f, 0f, 0f), 0f);
        }
       
        if (pantalla2.gameObject.activeSelf == false)
        {
            LeanTween.scale(pantalla2, new Vector3(0f, 0f, 0f), 0f);
        }

        if (pantalla3.gameObject.activeSelf == false)
        {
            LeanTween.scale(pantalla3, new Vector3(0f, 0f, 0f), 0f);
        }


        if (pantalla4.gameObject.activeSelf == false)
        {
            LeanTween.scale(pantalla4, new Vector3(0f, 0f, 0f), 0f);
        }

        if (pantalla5.gameObject.activeSelf == false)
        {
            LeanTween.scale(pantalla5, new Vector3(0f, 0f, 0f), 0f);
        }

        if (pantalla6.gameObject.activeSelf == false)
        {
           LeanTween.scale(pantalla6, new Vector3(0f, 0f, 0f), 0f);
        }


            //minimiza de nuevo el tamaño de las pantallas




        

    }
}