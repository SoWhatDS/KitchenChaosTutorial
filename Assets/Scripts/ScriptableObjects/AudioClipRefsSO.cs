using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(AudioClipRefsSO),menuName = "AudioClipSO/ " + nameof(AudioClipRefsSO))]
public class AudioClipRefsSO : ScriptableObject
{
    [field: SerializeField] public AudioClip[] Chop { get; private set; }
    [field: SerializeField] public AudioClip[] DeliverySuccess { get; private set; }
    [field: SerializeField] public AudioClip[] DeliveryFail { get; private set; }
    [field: SerializeField] public AudioClip[] FootStep { get; private set; }
    [field: SerializeField] public AudioClip[] ObjectDrop { get; private set; }
    [field: SerializeField] public AudioClip[] ObjectPickUp { get; private set; }
    [field: SerializeField] public AudioClip[] StoveSizzle { get; private set; }
    [field: SerializeField] public AudioClip[] Trash { get; private set; }
    [field: SerializeField] public AudioClip[] Warning { get; private set; }
}
