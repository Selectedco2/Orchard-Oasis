using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    [SerializeField]
    string itemName;

    [SerializeField]
    int amount;
    
    [SerializeField]
    Sprite image;

    InventoryController inventoryController;
    
    void Start()
    {
        inventoryController = GameObject.Find("InventoryParent").GetComponent<InventoryController>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inventoryController.AddItem(itemName, amount, image);
        }

    }
}
