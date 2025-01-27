using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private int _coins;
    [SerializeField] private int _rate;
    [SerializeField] private TextMeshProUGUI _currentText;
    
    [SerializeField] private Button _buttonClick;
    [SerializeField] private Button _buttonUpgrade;

    private void Start()
    {
        _buttonClick.onClick.AddListener(Click);
        _buttonUpgrade.onClick.AddListener(UpgradeClick);

    }
    private void Update()
    {
        _currentText.text = "Coins: " + _coins;
    }
    private void Click()
    {
        _coins += _rate;
    }

    private void UpgradeClick()
    {
        if(_coins >= 15)
        {
            _coins -= 15;
            _rate += 1;
        }
    }
    private void OnDestroy()
    {
        _buttonClick.onClick.RemoveListener(Click);
        _buttonUpgrade.onClick.RemoveListener(UpgradeClick);
    }
}
