using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDuoAnim : MonoBehaviour
{

    bool presssed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (presssed == false)
            {
                presssed = true;
                GetComponent<Animator>().SetBool("presssed", true);
            }
            else
            {
                presssed = false;
                GetComponent<Animator>().SetBool("presssed", false);
            }
        }
    }
}
