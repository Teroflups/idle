using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] private Sprite _audioON;
    [SerializeField] private Sprite _audioOFF;
    [SerializeField] private GameObject _buttonAudio;
    
    [SerializeField] private Slider _slider;

    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioSource _audio;

    private void Update()
    {
        _audio.volume = _slider.value;
    }

    public void OnOffAudio()
    {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume = 0;   
            _buttonAudio.GetComponent<Image>().sprite = _audioOFF;  
        }
        else
        {
            AudioListener.volume = 1;
            _buttonAudio.GetComponent<Image>().sprite = _audioON;
        }
    }
}

