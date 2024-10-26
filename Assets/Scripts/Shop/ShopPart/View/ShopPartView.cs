using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopPartView : MonoBehaviour
{
    [SerializeField] private TMP_Text headerHolder;
    [SerializeField] private TMP_Text descriptionHolder;

    [SerializeField] private Transform upperLayoutGroup;
    [SerializeField] private Transform lowerLayoutGroup;

    [SerializeField] private Image bigIcon;

    [SerializeField] private GameObject priceWithSaleObject;
    [SerializeField] private TMP_Text oldPriceWithSaleHolder;
    [SerializeField] private TMP_Text newPriceWithSaleHolder;
    [SerializeField] private TMP_Text saleHolder;

    [SerializeField] private GameObject priceWithoutSaleObject;
    [SerializeField] private TMP_Text priceWithoutSaleHolder;

    public void Initialize(string headerText,string descriptionText, GameObject[] objectsForUpperGroup, GameObject[] objectsForLowerGroup, Sprite bigIconImage,
        bool isPriceWithSale, string normalPrice, string salePrice, string salePercent)
    {
        headerHolder.text= headerText;
        descriptionHolder.text= descriptionText;

        foreach(var obj in objectsForUpperGroup)
        {
            obj.transform.parent = upperLayoutGroup;
        }

        foreach(var obj in objectsForLowerGroup)
        {
            obj.transform.parent= lowerLayoutGroup;
        }

        bigIcon.sprite=bigIconImage;

        if (isPriceWithSale)
        {
            oldPriceWithSaleHolder.text=normalPrice;
            newPriceWithSaleHolder.text= salePrice;
            saleHolder.text= salePercent;
            priceWithSaleObject.SetActive(true);
        }
        else
        {
            priceWithoutSaleHolder.text=normalPrice;
            priceWithoutSaleObject.SetActive(true);
        }
    }
}
