using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duoBoxTDAnim : MonoBehaviour
{

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
