using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(BurningRecipeSO),menuName = "BurningReciple/ " + nameof(BurningRecipeSO))]
public class BurningRecipeSO : ScriptableObject
{
    [field: SerializeField] public KitchenObjectSO Input { get; private set; }
    [field: SerializeField] public KitchenObjectSO Output { get; private set; }
    [field: SerializeField] public float BurningTimerMax { get; private set; }
}
