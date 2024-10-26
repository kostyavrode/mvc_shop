using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] private ShopView shopView;

    [SerializeField] private ShopPartsController shopPartsControllerPrefab;

    private void OnEnable()
    {
        shopView.onInputReceived += HandleReceivedInput;
    }
    private void OnDisable()
    {
        shopView.onInputReceived -= HandleReceivedInput;
    }
    private void HandleReceivedInput(int inputInt)
    {
        shopView.gameObject.SetActive(false);
        ShopPartsController shopPartsController=Instantiate(shopPartsControllerPrefab, this.transform);
        shopPartsController.CreateShopParts(inputInt);
    }
}
