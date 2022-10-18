using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Sound")]
public class SoundSO : ScriptableObject
{
    public AudioClip[] clips;

    public float baseVolume = 1f;
    public float volumeVariation = 0.1f;

    public float basePitch = 1f;
    public float pitchVariation = 0.1f;
    
    public Transform Play(Vector3 position)
    {
        return SoundManager.Play(this, position);
    }

    public AudioClip GetClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    public float GetVolume()
    {
        return baseVolume + Random.Range(-1f, 1f) * volumeVariation;
    }

    public float GetPitch()
    {
        return basePitch + Random.Range(-1f, 1f) * pitchVariation;
    }
}
