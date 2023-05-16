using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;

    Vector2 startPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� �� 
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        
        }
        //���콺 �� ��
        if (Input.GetMouseButtonUp(0))
        {
            //���콺 ��ư���� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //�������� ���̸� �ӵ��� ����
            this.speed = swipeLength / 500.0f;

            //ȿ���� ��� 
            GetComponent<AudioSource>().Play(); 
        }

        //�̵�
        transform.Translate(this.speed, 0, 0); 
        //����
        this.speed *= 0.98f;
    }
}