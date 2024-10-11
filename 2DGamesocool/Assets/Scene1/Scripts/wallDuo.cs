using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;



public class wallDuo : MonoBehaviour
{
    [SerializeField]
    GameObject buttonObj;
    [SerializeField]



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonObj.GetComponent<buttonDuo>().pressed)
        {
            GetComponent<BoxCollider2D>().enabled = false;
           
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = true;
            
        }
    }
}
