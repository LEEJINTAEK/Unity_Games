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
        //마우스 누를 때 
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        
        }
        //마우스 뗄 때
        if (Input.GetMouseButtonUp(0))
        {
            //마우스 버튼에서 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //스와이프 길이를 속도로 변경
            this.speed = swipeLength / 500.0f;

            //효과음 재생 
            GetComponent<AudioSource>().Play(); 
        }

        //이동
        transform.Translate(this.speed, 0, 0); 
        //감속
        this.speed *= 0.98f;
    }
}
