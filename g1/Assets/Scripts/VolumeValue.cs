using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValue : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        musicVolume = 1f;
    }

    
    void Update()
    {
        audioSrc.volume = musicVolume;
        musicVolume = PlayerPrefs.GetFloat("Volume");
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volume", musicVolume);
    }
}
