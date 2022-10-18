using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterSO characterSO;

    private void Start()
    {
        GetComponent<SoundRepeater>().sound = characterSO.stepSound;
        GetComponent<SoundRepeater>().stepDelay = characterSO.stepDelay;
    }
}
