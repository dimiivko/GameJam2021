using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMngrAssets : MonoBehaviour
{
    private static SoundMngrAssets _i;
    public static SoundMngrAssets i
    {
        get
        {
            if (_i == null) _i = (Instantiate(Resources.Load("SoundMngrAssets")) as GameObject).GetComponent<SoundMngrAssets>();
            return _i;
        }
    }
    public AudioClip begin;
}
