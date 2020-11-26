using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SettingsMenu : SingletonManager<SettingsMenu>
{

    public AudioMixer backgroundMixer;
    public AudioMixer sfxMixer;

    public void SetLevel(float sliderValue)
    {
        backgroundMixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        
    }

    public void SetSFXLevel(float sliderValue)
    {
        sfxMixer.SetFloat("SFXVol", Mathf.Log10(sliderValue) * 20);
    }

    public float BackgroundMusicVolume
    {
        get
        {
            if (backgroundMixer.GetFloat("MusicVol", out float value))
            {
                return Mathf.Pow(10, value) * 20;
            }
            else
            {
                return -1f;
            }
        }
    }

    public float SFXMusicVolume
    {
        get
        {
            if (sfxMixer.GetFloat("SFXVol", out float value))
            {
                return Mathf.Pow(10, value) * 20;
            }
            else
            {
                return -1f;
            }
        }
    }
}
