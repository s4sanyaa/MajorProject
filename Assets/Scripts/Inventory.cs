using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject item;

    public void AddItem(GameObject obj)
    {
        if (!item)
        {
            item = obj;
            obj.SetActive(false);
        }
    }

    public bool RemoveItem()
    {
        if (!item)
            return false;
        return true;
    }
}
