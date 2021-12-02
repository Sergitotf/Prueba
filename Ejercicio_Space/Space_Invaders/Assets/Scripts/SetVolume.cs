using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;

public class SetVolume : MonoBehaviour
{
    
    
    public Slider musicaSlider;
    public Slider efectosSlider;
    int idioma= 0;
    public int index;
   
    public void OnEnable()
    {
        efectosSlider.value = PlayerPrefs.GetFloat("EfectosVolume", 1.0f);
        musicaSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1.0f);

    }
    void Start()
    {
        
    }
    private void Update()
    {
        
    }
    //Guardar cambios de los slider
    public void AcceptMusicVolume()
    {
         PlayerPrefs.SetFloat("MusicVolume", musicaSlider.value);
        PlayerPrefs.SetFloat("EfectosVolume", efectosSlider.value);
        PlayerPrefs.Save();

    }
    //Cancelar cambios slider
    public void CancelMusicVolume()
    {
        efectosSlider.value = PlayerPrefs.GetFloat("EfectosVolume");
        musicaSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        

    }
    public void CambioIndex(int indice)
    {
        index = indice;
    }
    public void AcceptLanguage()
    {
        PlayerPrefs.SetInt("Idioma", idioma);
        PlayerPrefs.Save();

    }
    //Cancelar cambios slider
    public void CancelLanguage()
    {
        idioma = PlayerPrefs.GetInt("Idioma");
    }


}

//Control de sonido, mixer