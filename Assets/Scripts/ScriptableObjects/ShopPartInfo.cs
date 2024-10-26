using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ShopPartInfo", menuName ="Shop/New ShopPartInfo")]
public class ShopPartInfo : ScriptableObject
{
    [SerializeField] private string header;
    [SerializeField] private string description;
    [SerializeField] private ImageData[] items;
    [SerializeField] private string price;
    [SerializeField] private string sale;
    [SerializeField] private BigIconEnum bigIconName;

    public string Header => this.header;
    public string Description => this.description;
    public ImageData[] Items => this.items;
    public string Price => this.price;
    public string Sale => this.sale;
    public BigIconEnum BigIconName => this.bigIconName;
}
