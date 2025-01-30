using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private GameObject item;
    [SerializeField] private FoodId foodId;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�������");
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                Debug.Log("������� � ���");
                if (inventory.isFull[i] == false)
                {
                    Debug.Log("������� � ��");
                    inventory.isFull[i] = true;
                    Instantiate(item, inventory.slots[i].transform);
                    inventory.id.Add(foodId.ID);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
