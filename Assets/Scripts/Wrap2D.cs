using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Wrap2D : MonoBehaviour
{
       


    // Update is called once per frame
    void FixedUpdate()
    {   
        // IF PLAYER POSITION IS BELOW -0.625 THEN 
        if (transform.position.x <= -0.447f)

            // OUR NEW POSITION OF PLAYER WILL BE X(0.662, CURRENT Y, CURRENT Z)
            transform.position = new Vector3(0.484f, transform.position.y, transform.position.z);
        else if (transform.position.x >= 0.484f)
            transform.position = new Vector3(-0.447f, transform.position.y, transform.position.z);
    }
}
