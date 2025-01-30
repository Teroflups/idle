using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    [SerializeField] private string[] menu;
    [SerializeField] private Inventory inventory;
    [SerializeField] private GameObject[] _result;
    [SerializeField] private Transform dish;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            Crafting();
        }
    }
    private void Crafting()
    {
        string curDish = null;
        int result = 0;
        for(int i = 0; i < menu.Length; i++)
        {
            for (int j = 0; j < inventory.id.Count; j++)
            {
                if (menu[i].Contains(inventory.id[j])) 
                {
                    result += 1;
                    if(result == 3)
                    {
                        curDish = menu[i];
                        break;
                    }
                }
            }
        }
        if(result == 3)
        {
            for(int i = 0; i < _result.Length; i++)
            {
                if (_result[i].name == curDish)
                {
                    Instantiate(_result[i], dish);
                }
            }
        } 
    }
}
