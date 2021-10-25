using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Volume : MonoBehaviour
{
    public AudioSource mixer;

    void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20 );
    }
}
