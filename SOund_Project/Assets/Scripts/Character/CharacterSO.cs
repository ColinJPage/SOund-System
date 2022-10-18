using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Character")]
public class CharacterSO : ScriptableObject
{
    public float stepDelay;
    public SoundSO stepSound;
}
