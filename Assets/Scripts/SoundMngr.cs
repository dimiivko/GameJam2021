using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundMngr 
{
    
    public static void PlaySound()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(SoundMngrAssets.i.begin);
    }
}
