using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesItem : MonoBehaviour
{
    //��������ݲֿ�
    public Item item;
    //���������ݲֿ�
    public MainItem mainItem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

            if (!mainItem.itemList.Contains(item))
            {
                mainItem.itemList.Add(item);
            }
            item.itemNum += 1;
            BagDisplayUI.updateItemToUI();
            Destroy(this.gameObject);
        }
    }
}

