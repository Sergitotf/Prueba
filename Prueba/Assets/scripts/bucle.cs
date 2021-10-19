using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucle : MonoBehaviour
{
    public GameObject cubePrefab;
    public int[] arrayNumeros;
    public int Suma;
    public int Seis;
    public int Mayor;
    public int Contador;

    // Start is called before the first frame update
    void Start()
    {
        //for
        /*
        for (int i = 0; i < 5; i++)
        {
            Instantiate(cubePrefab, new Vector3(0.0f, 10f*1, 5f *(i+1)), Quaternion.identity);
            Debug.Log("Valor :" + i);
        }
        
        for (int i = 0; i < 10; i++)
        {
            Suma = Suma + arrayNumeros[i];
            Debug.Log(Suma);
            // Debug.Log("Contiene la posicion " + i + " el valor " + arrayNumeros[i]);
        }

        
        */
        // Contar veces que aparece el numero 6
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            int Seis = arrayNumeros[i];
            Contador++;
            Debug.Log("El numero 6 aparece" + i + "veces");
        }

        //escoger el numero mas alto

        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            if (Mayor < arrayNumeros[i]);
            {
                Mayor = arrayNumeros[i];
            }
            Debug.Log("El numero es el" + Mayor);
        }
        //while

    }

    // Update is called once per frame
    void Update()
    {

    }
}
