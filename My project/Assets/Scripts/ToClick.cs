using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToClick : MonoBehaviour
{
    public void ToClicker()
    {
        SceneManager.LoadScene(2);
    }
}
