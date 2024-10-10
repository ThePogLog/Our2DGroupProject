using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class britishAnim : MonoBehaviour
{
    bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("x", xInput);
        GetComponent<Animator>().SetFloat("y", yInput);
        if (Input.GetButtonDown("Fire1"))
        {
            if (selected == false)
            {
                selected = true;
                GetComponent<Animator>().SetBool("selected", true);
            }
            else
            {
                selected = false;
                GetComponent<Animator>().SetBool("selected", false);
            }
        }
    }
}
