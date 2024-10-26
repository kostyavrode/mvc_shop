using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPartsController: MonoBehaviour
{
    [SerializeField] private Sprite[] shopItemImageSprites;

    [SerializeField] private Sprite[] bigIconSprites;

    [SerializeField] private ShopPartView shopPartViewPrefab;

    [SerializeField] private Transform shopPartsContainer;

    private ShopPartInfo[] shopPartInfos;
    

    public void CreateShopParts(int count)
    {
        shopPartInfos=LoadAndGetShopPartInfos();
        InitShopPart(count);
    }

    private void InitShopPart(int count)
    {
        Debug.Log(shopPartInfos.Length);
        for (int i = 0;i<count;i++)
        {
            ShopPartView newShopPart=GameObject.Instantiate(shopPartViewPrefab,shopPartsContainer);
                newShopPart.Initialize(shopPartInfos[i].Header, shopPartInfos[i].Description,
                GetSpriteForShopItem(shopPartInfos[i].Items), GetQuantitiesForShopItem(shopPartInfos[i].Items)
                , GetBigIconSprite(shopPartInfos[i].BigIconName), GetIsSaleBool(shopPartInfos[i].Sale),shopPartInfos[i].Price.ToString(),
                GetCalculatedSaleAmount(shopPartInfos[i].Price,shopPartInfos[i].Sale).ToString(),shopPartInfos[i].Sale.ToString());
        }
    }

    private float GetCalculatedSaleAmount(float price,float sale)
    {
        return price * ((100-sale)/100);
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
        switch (iconEnum)
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
