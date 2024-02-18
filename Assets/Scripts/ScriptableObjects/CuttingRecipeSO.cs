using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(FryingRecipeSO),menuName = "CuttingReciple/ " + nameof(FryingRecipeSO))]
public class CuttingRecipeSO : ScriptableObject
{
    [field: SerializeField] public KitchenObjectSO Input { get; private set; }
    [field: SerializeField] public KitchenObjectSO Output { get; private set; }
    [field: SerializeField] public int CuttingProgressMax { get; private set; }
}
