using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botton_control : MonoBehaviour
{
    public Button option1;
    public GameObject inicio;

    void Start()
    {
        inicio.SetActive(true);
        option1.Select();
    }

    
    void Update()
    {
        
    }
    /* habilitar la selecci�n del primer bot�n
     public Button selectedButton; 
     
    void OnEnable()
    {
    selectedButton.Select();
    }
     */ 
    
}
