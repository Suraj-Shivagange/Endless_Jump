using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Down : MonoBehaviour
{

    float platformSpeed = .3f;
    bool endPoint;

    float startPoint;
    float endPointY;
    public float unitsToMove = .05f;

    void Start()
    {
        startPoint = transform.position.y;

        endPointY = startPoint + unitsToMove;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(endPoint)
        {
            transform.position += Vector3.up * platformSpeed * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.up * platformSpeed * Time.deltaTime;
        }

        if (transform.position.y >= endPointY)
        {
            endPoint = false;

        }   
        
        if(transform.position.y <= startPoint)
        {
            endPoint = true;
        }


    }
}
