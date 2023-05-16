using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 100;
        }
        //회전시키기
        transform.Rotate(0, 0, this.speed);

        //감속시키기
        this.speed *= 0.96f;
    }
}
