using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    float salud = 8f;
    int numero = 1;

    

    // Start is called before the first frame update
    void Start()
    {
        ShowHealth();
        salud = salud + 5f;
        ShowHealth();
        salud = salud - 6f;
        ShowHealth();
        salud = salud * 5f;
        ShowHealth();
        salud = salud / 4f + 4f;
        ShowHealth();
        salud = salud + numero;
        ShowHealth();
    }
    void ShowHealth()
    {
          Debug.Log("Valor de salud = " + salud + "HP");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class MiSegundoScript : MonoBehaviour
{
    

}