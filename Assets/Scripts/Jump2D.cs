using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2D : MonoBehaviour
{

    public bool grounded;           //TRUE OR FLASE BASED ON WHEATHER WE ARE GROUNDED
    public float jumpHeight = 50f;

    public Transform groundcheck;   // OBJECT WHICH WILL CHECK IF WE ARE GROUNDED

    public float groundRadius = 0.05f;       // RADIUS AROUND THE GROUNDCHECL OBJECT THAT WILL DETECT WE ARE GROUNDED OR NOT 
    public LayerMask ground;        // DECIDE WHICH LAYERS COUNT AS GROUNDED
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundRadius, ground);

        

        float Vely = GetComponent<Rigidbody2D>().velocity.y;
        
        if(grounded && Vely <=0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight));

            FindObjectOfType<AudioManager>().Play("jumpsound");
        }
        
    
    
    }

}
