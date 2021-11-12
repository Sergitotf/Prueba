using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;

public class SetVolume : MonoBehaviour
{
    
    public AudioSource globalMusic;
    public Slider musicaSlider;
    public LocalizationSettings idiomaSettings;
    public int index;

    void Start()
    {
        musicaSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        globalMusic.volume = musicaSlider.value;
       /* PlayerPrefs.SetFloat("MusicVolume", globalMusic.volume);
        musicaSlider.value = globalMusic.volume;
        PlayerPrefs.SetInt("index", index);*/
    }
    
    public void AcceptMusicVolume()
    {
        globalMusic.volume = musicaSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", musicaSlider.value);
        /*
        PlayerPrefs.SetFloat("MusicVolume", globalMusic.volume);
        PlayerPrefs.SetInt("index", index);
        idiomaSettings.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[PlayerPrefs.GetInt("Index")]); */

    }
    public void CancelMusicVolume()
    {
        globalMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        musicaSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        idiomaSettings.SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[PlayerPrefs.GetInt("Index")]);

    }
    public void CambioIndex(int indice)
    {
        index = indice;
    }
}

//Control de sonido, mixer