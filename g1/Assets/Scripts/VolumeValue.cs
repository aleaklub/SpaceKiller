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
        FirstOpen();
       
    }

    
    void Update()
    {
        audioSrc.volume = musicVolume;
        musicVolume = PlayerPrefs.GetFloat("Volume");
        
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("Volume", vol);
    }
    public void FirstOpen()
    {
        if (PlayerPrefs.GetInt("firstopen") == 0)
        {
            PlayerPrefs.SetInt("firstopen", 1);
            PlayerPrefs.SetFloat("Volume", musicVolume);
        }
    }
    
}
