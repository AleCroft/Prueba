using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float velocidadsalto;

    bool jumpRequest;

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
           jumpRequest = true;
        }
    }

    void FixedUpdate()
    {
        if (jumpRequest)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * velocidadsalto, ForceMode2D.Impulse);

            jumpRequest = false;
        }
    }
}
