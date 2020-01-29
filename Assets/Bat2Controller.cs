using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat2Controller : MonoBehaviour
{
    private Rigidbody2D p2;
    Vector2 v2;

    // Start is called before the first frame update
    void Start()
    {
        p2 = GetComponent<Rigidbody2D>();
        //p1.position = new Vector2(-14.09f, 0.03550553f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            //Debug.Log(v1.x);
            //Debug.Log(v1.y);
            p2.velocity = new Vector2(0f, 17f); ;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            p2.velocity = new Vector2(0f, -17f);
        }
        else
        {
            p2.velocity = new Vector2(0f, 0f); ;
        }
    }
}
