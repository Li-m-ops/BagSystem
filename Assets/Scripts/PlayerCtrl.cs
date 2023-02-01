using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    Vector3 v3;
    float speed = 2f;
    public GameObject myBagUI;
    private bool isPlay;

    // Update is called once per frame
    void Update()
    {
        //���ƽ�ɫ�ƶ�
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        v3 = new Vector3(x, 0, y);
        transform.Translate(v3 * speed * Time.deltaTime);

        //����UI��ʾ������
        if (Input.GetKeyDown(KeyCode.B))
        {
            isPlay = !isPlay;
            myBagUI.SetActive(isPlay);
        }
    }
}
