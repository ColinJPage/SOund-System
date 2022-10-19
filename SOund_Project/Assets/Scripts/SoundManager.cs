using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static Transform Play(SoundSO sound, Vector3 position)
    {
        var source = GetNewSource();
        source.clip = sound.GetClip();
        source.volume = sound.GetVolume();
        source.pitch = sound.GetPitch();

        source.transform.position = position;

        source.Play();

        Destroy(source.gameObject, source.clip.length);
        return source.transform;
    }

    private static AudioSource GetNewSource()
    {
        var source = new GameObject("Sound").AddComponent<AudioSource>();
        source.spatialBlend = 1f;
        return source;
    }

}
