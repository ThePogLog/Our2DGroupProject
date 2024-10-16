using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleBox : MonoBehaviour
{
    bool selected = true;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1.0f;
        GetComponent<Rigidbody2D>().mass = 30f;
        GetComponent<Rigidbody2D>().drag = 0f;
        GetComponent<Rigidbody2D>().angularDrag = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (selected == false)
            {
                selected = true;
                GetComponent<Rigidbody2D>().gravityScale = 1.0f;
                GetComponent<Rigidbody2D>().mass = 30f;
                GetComponent<Rigidbody2D>().drag = 0f;
                GetComponent<Rigidbody2D>().angularDrag = 0.05f;
            }
            else
            {
                selected = false;
                GetComponent<Rigidbody2D>().gravityScale = 0.0f;
                GetComponent<Rigidbody2D>().mass = 50f;
                GetComponent<Rigidbody2D>().drag = 0.7f;
                GetComponent<Rigidbody2D>().angularDrag = 0.05f;
            }
        }
    }
}
