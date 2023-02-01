using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagDisplayUI : MonoBehaviour
{
    //����ģʽ
    static BagDisplayUI bagDisplayUI;
    private void Awake()
    {
        if (bagDisplayUI != null)
        {
            Destroy(this);

        }
        bagDisplayUI = this;

    }
    //ÿ����Ϸ����ǰ����̬�ĸ��±���UIԪ��
    private void OnEnable()
    {
        updateItemToUI();
    }
    //�������ݲֿ⡢����������Ԥ���塢��UI����ʾ����Ԫ�صĸ�Ԫ��
    public MainItem mainItem;
    public Grid gridPrefab;
    public GameObject myBag;

    /// <summary>
    /// ��UI�н�һ����������ݲֿ���ʾ����
    /// </summary>
    /// <param name="item"></param>
    public static void insertItemToUI(Item item)
    {

        Grid grid = Instantiate(bagDisplayUI.gridPrefab, bagDisplayUI.myBag.transform);
        grid.gridImage.sprite = item.itemImage;
        grid.girdNum.text = item.itemNum.ToString();

    }

    /// <summary>
    /// ���������ݲֿ�������������ʾ��UI��
    /// </summary>
    public static void updateItemToUI()
    {
        for (int i = 0; i < bagDisplayUI.myBag.transform.childCount; i++)
        {
            Destroy(bagDisplayUI.myBag.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < bagDisplayUI.mainItem.itemList.Count; i++)
        {
            insertItemToUI(bagDisplayUI.mainItem.itemList[i]);
        }
    }

    public void ClearBag()
    {
        for (int i = 0; i < bagDisplayUI.mainItem.itemList.Count; i++)
        {
            bagDisplayUI.mainItem.itemList[i].itemNum = 0;
        }
        bagDisplayUI.mainItem.itemList.Clear();
        updateItemToUI();
    }
}
