using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public SwitchManager customToggle;
    public bool isPlaying;
    
    private void Start()
    {
        audioSource.clip = audioClip;
        audioSource.loop = true;
        audioSource.Play();
    }
    public void SoundOnAndOff()
    {
        if(customToggle.isOn)
        {
            audioSource.Pause();
            isPlaying = false;
        }
        else
        {
            audioSource.Play();
            isPlaying = true;
        }
    }
}
