using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour
{
    [SerializeField] private ShopController shopPrefab;
    public void StartScene()
    {
        UIRootView uIRootView = Object.FindObjectOfType<UIRootView>();
        ShopController shop=Instantiate(this.shopPrefab);
        uIRootView.AttachSceneUI(shop.gameObject);
    }
}
