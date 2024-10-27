using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour
{
    [SerializeField] private ShopController shopPrefab;

    private UIRootView uiRoot;

    public void Initialize(UIRootView uiRoot)
    {
        this.uiRoot = uiRoot;
    }

    public void StartScene()
    {
        ShopController shop=Instantiate(shopPrefab);
        uiRoot.AttachSceneUI(shop.gameObject);
    }
}
