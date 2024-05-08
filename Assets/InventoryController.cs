using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
