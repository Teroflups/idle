using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private Button _play;
    void Start()
    {
        _play.onClick.AddListener(ToScene);
    }
    private void ToScene()
    {
        SceneManager.LoadScene(1);
    }
    private void OnDestroy()
    {
        _play.onClick.RemoveListener(ToScene);
    }
}
