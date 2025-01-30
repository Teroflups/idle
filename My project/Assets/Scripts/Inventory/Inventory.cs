using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public List<string> id = new List<string>();    
    public List<string> menu = new List<string>();
}
