using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpplat2D : MonoBehaviour
{
    public float jumpHeight = 200;      //PLAYER JUMP HEIGHT WHEN HITTING TRIGGER
    float VelY;                         //VARIABLE THAT CAN BE SEEN THROUGHT THE SCRIPT AND REFFERENCED TO

    // Update is called once per frame
    void Update()
    {
        // REFERENCES OUR PLAYERS CURRENT Y VELOCITY
        VelY = GetComponent<Rigidbody2D>().velocity.y;
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        // PLAYER COLLIDES WITH TAG JUMPLAT AND HIS VELOCITY LESS OR = 0 THEN 
        if (other.tag == "JumpPlat" && VelY <= 0)
        {
            // NULLIFI HIS CURRENT VELOCITY FOR X/Y TO 0
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            // INCREASE HIS Y FORCE BY JUMPHEIGHT
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight));

            FindObjectOfType<AudioManager>().Play("jumpsound");
        }
    }
}
