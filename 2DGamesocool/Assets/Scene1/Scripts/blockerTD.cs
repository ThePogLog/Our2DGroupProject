using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockerTD : MonoBehaviour
{
    [SerializeField]
    GameObject customer;
    [SerializeField]
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (customer.GetComponent<customerRequest>().youGotIt)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Animator>().SetBool("on", false);
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<Animator>().SetBool("on", true);
        }
    }
}
