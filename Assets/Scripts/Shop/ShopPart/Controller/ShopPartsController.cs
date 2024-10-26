using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPartsController: MonoBehaviour
{
    [SerializeField] private Sprite[] shopItemImageSprites;

    [SerializeField] private Sprite[] bigIconSprites;

    [SerializeField] private ShopPartView shopPartViewPrefab;

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
            newShopPart.Initialize(shopPartInfo.Header,shopPartInfo.Description,GetSpriteForShopItem(shopPartInfo.Items), GetQuantitiesForShopItem(shopPartInfo.Items)
                ,GetBigIconSprite(shopPartInfo.BigIconName),GetIsSaleBool(shopPartInfo.Sale),shopPartInfo.Price.ToString(),
                GetCalculatedSaleAmount(shopPartInfo.Price,shopPartInfo.Sale).ToString(),shopPartInfo.Sale.ToString());
        }
    }

    private float GetCalculatedSaleAmount(int price,int sale)
    {
        return price * (sale / 100);
    }

    private bool GetIsSaleBool(int sale)
    {
        if (sale > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private string[] GetQuantitiesForShopItem(ImageData[] itemsData)
    {
        List<string> quantities = new List<string>();
        foreach (ImageData item in itemsData)
        {
            quantities.Add(item.quantity);
        }
        return quantities.ToArray();
    }

    private Sprite GetBigIconSprite(BigIconEnum iconEnum)
    {
        switch(iconEnum)
        {
            case BigIconEnum.WoodWithAxe:
                return bigIconSprites[0];
            default:
                return bigIconSprites[0];
        }
    }

    private Sprite[] GetSpriteForShopItem(ImageData[] itemsData)
    {
        List<Sprite> rightSprites= new List<Sprite>();
        foreach(ImageData item in itemsData)
        {
            switch(item.image)
            {
                case ShopPartItemIconEnum.Metal:
                    rightSprites.Add(shopItemImageSprites[0]);
                    break;
                case ShopPartItemIconEnum.Wood:
                    rightSprites.Add(shopItemImageSprites[1]);
                    break;
                case ShopPartItemIconEnum.Banana:
                    rightSprites.Add(shopItemImageSprites[2]);
                    break;
                default:
                    rightSprites.Add(shopItemImageSprites[0]);
                    break;
            }
        }
        return rightSprites.ToArray();
    }

    private ShopPartInfo[] LoadAndGetShopPartInfos()
    {
        return Resources.LoadAll<ShopPartInfo>("Shop/ShopParts");
    }
}
