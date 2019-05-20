using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25f;
        } else
        {
            speed = 10f;
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0,0,1) * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, 0, -1) * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(1, 0, 0) * speed);
        }
    }
}
