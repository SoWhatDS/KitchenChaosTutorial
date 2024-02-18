using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(RecipeSO),menuName ="RecipeForManager/ " + nameof(RecipeSO))]
public class RecipeSO : ScriptableObject
{
    [field: SerializeField] public List<KitchenObjectSO> KitchenObjectSOList { get; private set; }
    [field: SerializeField] public string RecipeName { get; private set; }
}
