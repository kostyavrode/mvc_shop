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

    [SerializeField] private GameObject priceWitoutSaleObject;
    [SerializeField] private TMP_Text priceWithoutSaleHolder;

    public void Initialize()
    {

    }
}
