using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    [SerializeField] private Slider _progressBar;
    [SerializeField] private float _decayRate;
    [SerializeField] private float _barAmount;
    private float _currentProgress = 0;

    private void Start()
    {
        _progressBar.value = 0; 
    }

    private void Update()
    {
        _currentProgress -= _decayRate * Time.deltaTime;
        _currentProgress = Mathf.Clamp(_currentProgress, 0, _progressBar.maxValue);
        _progressBar.value = _currentProgress;
    }

    public void BarProgress()
    {
        _currentProgress += _barAmount;
        _currentProgress = Mathf.Clamp(_currentProgress, 0, _progressBar.maxValue);
        _progressBar.value = _currentProgress;
    }
}
