using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    [SerializeField] private Button _menu;
    void Start()
    {
        _menu.onClick.AddListener(ToMenu);
    }

    private void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    private void OnDestroy()
    {
        _menu.onClick.RemoveListener(ToMenu);   
    }
}
