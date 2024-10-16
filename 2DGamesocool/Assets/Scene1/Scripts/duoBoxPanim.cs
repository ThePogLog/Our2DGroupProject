using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duoBoxPanim : MonoBehaviour
{

    bool selected = true;
    // Start is called before the first frame update
    void Start()
    {
        selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (selected == false)
            {
                selected = true;
                GetComponent<Animator>().SetBool("selected", false);
            }
            else
            {
                selected = false;
                GetComponent<Animator>().SetBool("selected", true);
            }
        }
    }
}
