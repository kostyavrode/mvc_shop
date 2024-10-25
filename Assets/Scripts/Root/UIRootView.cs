using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRootView : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Transform uiSceneContainer;

    private void Awake()
    {
        SetLoadingScreenEnabledState(false);
    }

    public void SetLoadingScreenEnabledState(bool state)
    {
        loadingScreen.SetActive(state);
    }
    public void AttachSceneUI(GameObject obj)
    {
        ClearSceneUI();
        obj.transform.SetParent(uiSceneContainer, false);
    }
    private void ClearSceneUI()
    {
        var childCount = uiSceneContainer.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Destroy(uiSceneContainer.GetChild(i).gameObject);
        }
    }
}
