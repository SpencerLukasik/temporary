using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SetVolume : MonoBehaviour
{  
    public AudioMixer mixer;
    void Start()
    {
        setVolumeLevel(.1f);
    }

    public void setVolumeLevel(float sliderValue){
        mixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }
}