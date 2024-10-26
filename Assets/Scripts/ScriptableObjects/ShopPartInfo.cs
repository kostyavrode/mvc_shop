using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ShopPartInfo", menuName ="Shop/New ShopPartInfo")]
public class ShopPartInfo : ScriptableObject
{
    [SerializeField] private string header;
    [SerializeField] private string description;
    [SerializeField] private ImageData[] items;
    [SerializeField] private int price;
    [SerializeField] private int sale;
    [SerializeField] private BigIconEnum bigIconName;

    public string Header => this.header;
    public string Description => this.description;
    public ImageData[] Items => this.items;
    public int Price => this.price;
    public int Sale => this.sale;
    public BigIconEnum BigIconName => this.bigIconName;
}
