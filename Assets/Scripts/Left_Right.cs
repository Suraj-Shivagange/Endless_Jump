using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Right : MonoBehaviour
{

    float platformSpeed = .3f;
    bool endPoint;
    

    // Update is called once per frame
    void Update()
    {
        if(endPoint)
        {
            transform.position += Vector3.right * platformSpeed * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.right * platformSpeed * Time.deltaTime;
        }

        if (transform.position.x >= 0.484f)
        {
            endPoint = false;

        }   
        
        if(transform.position.x <= -0.447f)
        {
            endPoint = true;
        }


    }
}
