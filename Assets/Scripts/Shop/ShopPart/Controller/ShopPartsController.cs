using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPartsController
{
    private ShopPartView shopPartViewPrefab;

    private ShopPartInfo[] shopPartInfos;
    
    private Transform shopPartsContainer;

    public void CreateShopParts()
    {
        shopPartInfos=LoadAndGetShopPartInfos();
    }

    private void CreateShopItems()
    {
        foreach(ShopPartInfo shopPartInfo in shopPartInfos)
        {
            ShopPartView newShopPart=GameObject.Instantiate(shopPartViewPrefab,shopPartsContainer);
            //newShopPart.Initialize();
        }
    }

    private void AnalyzeShopPartInfo()
    {

    }

    private void SendDataToView(ShopPartInfo info,ShopPartView view)
    {
        //view.Initialize(info.Header,info.Description,);
    }



    private ShopPartInfo[] LoadAndGetShopPartInfos()
    {
        return Resources.LoadAll<ShopPartInfo>("Shop/ShopParts");
    }
}
