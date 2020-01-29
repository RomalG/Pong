using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat1Controller : MonoBehaviour
{
    private Rigidbody2D p1;
    Vector2 v1;

    // Start is called before the first frame update
    void Start()
    {
        p1 = this.GetComponent<Rigidbody2D>();
        //p1.position = new Vector2(-14.09f, 0.03550553f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            p1.velocity = new Vector2(0f, 17f); ;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            p1.velocity = new Vector2(0f, -17f);
        }
        else
        {
            p1.velocity = new Vector2(0f, 0f); ;
        }
    }
}