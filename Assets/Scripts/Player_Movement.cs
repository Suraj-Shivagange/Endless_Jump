using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed = 2.5f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // FLOAT H ALLOWS THE PLAYER TO MOVE USING W OR UP ARROW KEY
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
    }
}
