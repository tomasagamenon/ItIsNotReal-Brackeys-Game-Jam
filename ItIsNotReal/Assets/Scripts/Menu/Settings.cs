using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer masterMixer;
    public void MasterVolume(float volume)
    {
        masterMixer.SetFloat("Master", volume);
    }
    public void MusicVolume(float volume)
    {
        masterMixer.SetFloat("Music", volume);
    }
    public void AudioVolume(float volume)
    {
        masterMixer.SetFloat("Audio", volume);
    }
    public void ToggleFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void Sensitivity(float sensitivity)
    {
        masterMixer.SetFloat("Audio", sensitivity);
    }
}
