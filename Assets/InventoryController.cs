using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class InventoryController : MonoBehaviour
{
    public GameObject Inventory;
    public bool isActivated;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory") && isActivated)
        {
            Inventory.SetActive(false);
            isActivated = false;
        }

        // else if eftersom man kan aktivera båda annars samtidigt

        else if (Input.GetButtonDown("Inventory") && !isActivated)
        {
            Inventory.SetActive(true);
            isActivated = true;
        }
    
    }

    public void AddItem(string itemName, int amount, Sprite image)
    {
        Debug.Log("itemname = " + itemName + itemName + "amount = " + amount + "image = " + image);
    }
}
