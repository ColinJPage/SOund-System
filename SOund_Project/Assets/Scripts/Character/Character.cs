using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterSO characterSO;

    private void Start()
    {
        GetComponent<SoundRepeater>().sound = characterSO.stepSound;
        GetComponent<SoundRepeater>().stepDelay = characterSO.stepDelay;
        GetComponentInChildren<Renderer>().material.color = characterSO.color;
    }
}
