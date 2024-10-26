using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopPartView : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private TMP_Text headerHolder;
    [SerializeField] private TMP_Text descriptionHolder;

    [Header("items")]
    [SerializeField] private Image[] itemImage;
    [SerializeField] private TMP_Text[] itemCountHolder;

    [Header("Big Icon")]
    [SerializeField] private Image bigIcon;

    [Header("Sale Prices")]
    [SerializeField] private GameObject priceWithSaleObject;
    [SerializeField] private TMP_Text oldPriceWithSaleHolder;
    [SerializeField] private TMP_Text newPriceWithSaleHolder;
    [SerializeField] private TMP_Text saleHolder;

    [Header("Without Sale Prices")]
    [SerializeField] private GameObject priceWithoutSaleObject;
    [SerializeField] private TMP_Text priceWithoutSaleHolder;

    public void Initialize(string headerText,string descriptionText, Sprite[] itemSprites, string[] itemCount, Sprite bigIconImage,
        bool isPriceWithSale, string normalPrice, string salePrice, string salePercent)
    {
        headerHolder.text= headerText;
        descriptionHolder.text= descriptionText;

        for (int i = 0; i < itemSprites.Length-1; i++)
        {
            itemImage[i].sprite = itemSprites[i];
            itemCountHolder[i].text = itemCount[i];
            itemImage[i].gameObject.SetActive(true);
        }

        bigIcon.sprite=bigIconImage;

        if (isPriceWithSale)
        {
            oldPriceWithSaleHolder.text=normalPrice;
            newPriceWithSaleHolder.text= salePrice;
            saleHolder.text="-" + salePercent + "%";
            priceWithSaleObject.SetActive(true);
        }
        else
        {
            priceWithoutSaleHolder.text=normalPrice;
            priceWithoutSaleObject.SetActive(true);
        }
    }
}
