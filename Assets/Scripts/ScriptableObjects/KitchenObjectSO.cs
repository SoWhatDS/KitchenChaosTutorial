using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(KitchenObjectSO),menuName = "KitchenObjects/ " + nameof(KitchenObjectSO))]
public class KitchenObjectSO : ScriptableObject
{
    [field: SerializeField] public Transform Prefab { get; private set; }
    [field: SerializeField] public Sprite Sprite { get; private set; }
    [field: SerializeField] public string ObjectName { get; private set; }
}
