using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class SoundRepeater : MonoBehaviour
{
    public SoundSO sound;
    public float stepDelay = 0.5f;

    private void OnEnable()
    {
        StartCoroutine(Playing());
    }

    private IEnumerator Playing()
    {
        while (true)
        {
            sound.Play(transform.position).SetParent(transform);
            yield return new WaitForSeconds(stepDelay);
        }
    }
}
