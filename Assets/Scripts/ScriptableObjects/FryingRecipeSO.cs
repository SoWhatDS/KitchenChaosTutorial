using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(FryingRecipeSO),menuName = "FryingReciple/ " + nameof(FryingRecipeSO))]
public class FryingRecipeSO : ScriptableObject
{
    [field: SerializeField] public KitchenObjectSO Input { get; private set; }
    [field: SerializeField] public KitchenObjectSO Output { get; private set; }
    [field: SerializeField] public float FryingTimerMax { get; private set; }
}
