using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObject 
{
    Transform GetKitchenObjectFollowTransform();

    void SetKitchenObject(KitchenObject kitchenObject);

    KitchenObject GetKitchenObject();

    void ClearKitchenObject();

    bool HasKitchenObject();
}
