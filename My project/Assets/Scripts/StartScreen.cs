using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _open;
    [SerializeField] private Button _close;
    [SerializeField] private GameObject _panel;
    void Start()
    {
        _play.onClick.AddListener(ToScene);
        _open.onClick.AddListener(OpenPanel);
        _close.onClick.AddListener(ClosePanel);
    }
    private void ToScene()
    {
        SceneManager.LoadScene(1);
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
        _play.onClick.RemoveListener(ToScene);
        _open.onClick.RemoveListener(OpenPanel);
        _close.onClick.RemoveListener(ClosePanel);
    }
}
