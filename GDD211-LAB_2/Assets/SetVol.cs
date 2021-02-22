using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVol : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float sliderVol)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderVol) * 20);
    }
}
