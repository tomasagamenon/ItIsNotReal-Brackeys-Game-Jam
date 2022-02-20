using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer masterMixer;
    //public AudioMixer musicMixer;
    //public AudioMixer audioMixer;
    public void MasterVolume(int volume)
    {
        masterMixer.SetFloat("Master", volume);
    }
    public void MusicVolume(int volume)
    {
        masterMixer.SetFloat("Music", volume);
    }
    public void AudioVolume(int volume)
    {
        masterMixer.SetFloat("Audio", volume);
    }
}
