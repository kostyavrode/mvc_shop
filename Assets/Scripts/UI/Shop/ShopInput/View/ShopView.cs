using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class ShopView : MonoBehaviour
{
    public Action<int> onInputReceived;

    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button startButton;

    private void OnEnable()
    {
        startButton.onClick.AddListener(ReceiveInput);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(ReceiveInput);
    }

    private void ReceiveInput()
    {
        if (int.TryParse(inputField.text, out int number) && number >= 1 && number <= 6)
        {
            onInputReceived?.Invoke(number);
        }
        else
        {
            Debug.LogError("Некорректный ввод");
        }
    }
}
