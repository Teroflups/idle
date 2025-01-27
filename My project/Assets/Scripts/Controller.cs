using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        _coins = PlayerPrefs.GetInt("Coins", 0);
        _rate = PlayerPrefs.GetInt("Rate", 1);
    }
    private void Update()
    {
        _currentText.text = "Coins: " + _coins;
    }
    private void Click()
    {
        _coins += _rate;
        PlayerPrefs.SetInt("Coins", _coins);
    }

    private void UpgradeClick()
    {
        if (_coins >= 15)
        {
            _coins -= 15;
            _rate += 1;

            PlayerPrefs.SetInt("Coins", _coins);
            PlayerPrefs.SetInt("Rate", _rate);
        }
    }
    private void OnDestroy()
    {
        _buttonClick.onClick.RemoveListener(Click);
        _buttonUpgrade.onClick.RemoveListener(UpgradeClick);
    }

    public void RefreshLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PLayerPrefs()
    {
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Rate", 1);
    }
}
