using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemView : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TMP_Text itemCountHolder;

    public void Initialize(Sprite sprite, string count)
    {
        image.sprite = sprite;
        itemCountHolder.text = count;
    }
}
