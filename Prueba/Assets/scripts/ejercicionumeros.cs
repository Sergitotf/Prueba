using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicionumeros : MonoBehaviour
    
{
    public int contador;
    public int[] arrayNumeros;
    public int Mayor;
    public int Seis;
    // Start is called before the first frame update
    void Start()
    {
        // Contar veces que aparece el numero 6
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            int Seis = arrayNumeros[i];
            contador++;
            Debug.Log("El numero 6 aparece" + i + "veces");
        }

        //escoger el numero mas alto
        Mayor = arrayNumeros[0];
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            if (Mayor < arrayNumeros[i]);
            {
                Mayor = arrayNumeros[i];
            }
        }
        Debug.Log("El numero es el" + Mayor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
