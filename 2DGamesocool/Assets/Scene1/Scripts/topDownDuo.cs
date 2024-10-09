using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class topDownDuo : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 10f;
    bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (selected == false)
            {
                selected = true;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
            else
            {selected = false;

            }
        }

            if (selected == true)
        {
            float xInput = Input.GetAxis("Horizontal");
            float yInput = Input.GetAxis("Vertical");
            //velocity is a Vector2 variable, storing 2 floats, x and y
            GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, yInput) * moveSpeed;
        }

        if (selected == false)
        {

            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }

        }
}
