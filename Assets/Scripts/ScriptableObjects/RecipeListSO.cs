using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName =nameof(RecipeListSO),menuName ="RecipeSO/ " + nameof(RecipeListSO))]
public class RecipeListSO : ScriptableObject
{
    [field: SerializeField] public List<RecipeSO> RecipeSOList;
}
