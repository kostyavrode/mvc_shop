using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] private ShopView shopView;

    [SerializeField] private ShopPartsController shopPartsControllerPrefab;

    private void Initialize()
    {
        shopView.onInputReceived += HandleReceivedInput;
    }
    private void HandleReceivedInput(int inputInt)
    {
        Instantiate(shopPartsControllerPrefab,this.transform);
    }
}
