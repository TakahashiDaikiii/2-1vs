using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;

    int moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = rb.velocity;

        if(Input.GetKey(KeyCode.RightArrow))
        {
            v.x = moveSpeed;
        }
        else
        {
            v.x = 0;
        }
        rb.velocity = v;
    }
}
