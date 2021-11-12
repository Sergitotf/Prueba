using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    
    public AudioSource globalMusic;
    public Slider musicaSlider;

    void Start()
    {
        PlayerPrefs.SetFloat("MusicVolume", globalMusic.volume);
        musicaSlider.value = globalMusic.volume;
    }
    
    public void AcceptMusicVolume()
    {
        globalMusic.volume = musicaSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", globalMusic.volume);

    }
    public void CancelMusicVolume()
    {
        globalMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        musicaSlider.value = PlayerPrefs.GetFloat("MusicVolume");

    }
}

//Control de sonido, mixer