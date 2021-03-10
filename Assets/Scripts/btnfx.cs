using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnfx : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hover;
    public AudioClip click;
    public AudioClip exit;

    public void HoverSound()
    {
        myFx.PlayOneShot(hover);

    }
    public void ClickSound()
    {
        myFx.PlayOneShot(hover);

    }
    public void ClickExitSound()
    {
        myFx.PlayOneShot(hover);

    }
}
