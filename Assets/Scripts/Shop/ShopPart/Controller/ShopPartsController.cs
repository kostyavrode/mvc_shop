using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPartsController
{
    private ShopPartView shopPartViewPrefab;

    private List<ShopPartInfo> shopPartInfos;
    
    private Transform shopPartsContainer;
    

    private void CreateShopItems()
    {
        foreach(ShopPartInfo shopPartInfo in shopPartInfos)
        {
            ShopPartView newShopPart=GameObject.Instantiate(shopPartViewPrefab,shopPartsContainer);
            
        }
    }
}
