using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ʵ�ֿ�����Asset���ڴ�����Դ�ļ��ķ���
[CreateAssetMenu(fileName = "New Item", menuName = "Bag/New Item")]

public class Item : ScriptableObject
{
    //����������Ҫ��UI����ʾ��ͼƬ�����������������������Ϣ������
    public string itemName;
    public Sprite itemImage;
    public int itemNum;
    [TextArea] //�ı�������ʽ����ʾ���������
    public string itemInfo;
}
