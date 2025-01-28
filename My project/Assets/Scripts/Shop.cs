using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    [SerializeField] private Button _buttonOpen;
    [SerializeField] private Button _buttonClose;

    private void Start()
    {
        _buttonOpen.onClick.AddListener(OpenPanel);
        _buttonClose.onClick.AddListener(ClosePanel);
    }

    private void OpenPanel()
    {
        if (_panel != null)
        {
            _panel.SetActive(true);
        }
    }

    private void ClosePanel()
    {
        if (_panel != null)
        {
            _panel.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        _buttonOpen.onClick.RemoveListener(OpenPanel);
        _buttonClose.onClick.RemoveListener(ClosePanel);
    }
}
