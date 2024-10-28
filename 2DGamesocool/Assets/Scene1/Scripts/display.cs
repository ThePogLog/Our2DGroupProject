using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour
{

    [SerializeField]
    Animator anim;

    [SerializeField]
    GameObject request;
    // Start is called before the first frame update
    void Start()
    {
        if (request.GetComponent<customerRequest>().cPlusF)
        {
            GetComponent<Animator>().SetBool("cPlusF", true);
        }
        if (request.GetComponent<customerRequest>().cPlusW)
        {
            GetComponent<Animator>().SetBool("cPlusW", true);
        }
        if (request.GetComponent<customerRequest>().cPlusE)
        {
            GetComponent<Animator>().SetBool("cPlusE", true);
        }
        if (request.GetComponent<customerRequest>().cPlusWi)
        {
            GetComponent<Animator>().SetBool("cPlusWi", true);
        }

        if (request.GetComponent<customerRequest>().bPlusF)
        {
            GetComponent<Animator>().SetBool("bPlusF", true);
        }
        if (request.GetComponent<customerRequest>().bPlusW)
        {
            GetComponent<Animator>().SetBool("bPlusW", true);
        }
        if (request.GetComponent<customerRequest>().bPlusE)
        {
            GetComponent<Animator>().SetBool("bPlusE", true);
        }
        if (request.GetComponent<customerRequest>().bPlusWi)
        {
            GetComponent<Animator>().SetBool("bPlusWi", true);
        }

        if (request.GetComponent<customerRequest>().mPlusF)
        {
            GetComponent<Animator>().SetBool("mPlusF", true);
        }
        if (request.GetComponent<customerRequest>().mPlusW)
        {
            GetComponent<Animator>().SetBool("mPlusW", true);
        }
        if (request.GetComponent<customerRequest>().mPlusE)
        {
            GetComponent<Animator>().SetBool("mPlusE", true);
        }
        if (request.GetComponent<customerRequest>().mPlusWi)
        {
            GetComponent<Animator>().SetBool("mPlusWi", true);
        }

        if (request.GetComponent<customerRequest>().hPlusF)
        {
            GetComponent<Animator>().SetBool("hPlusF", true);
        }
        if (request.GetComponent<customerRequest>().hPlusW)
        {
            GetComponent<Animator>().SetBool("hPlusW", true);
        }
        if (request.GetComponent<customerRequest>().hPlusE)
        {
            GetComponent<Animator>().SetBool("hPlusE", true);
        }
        if (request.GetComponent<customerRequest>().hPlusWi)
        {
            GetComponent<Animator>().SetBool("hPlusWi", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (request.GetComponent<customerRequest>().cPlusF)
        {
            GetComponent<Animator>().SetBool("cPlusF", true);
        }
        if (request.GetComponent<customerRequest>().cPlusW)
        {
            GetComponent<Animator>().SetBool("cPlusW", true);
        }
        if (request.GetComponent<customerRequest>().cPlusE)
        {
            GetComponent<Animator>().SetBool("cPlusE", true);
        }
        if (request.GetComponent<customerRequest>().cPlusWi)
        {
            GetComponent<Animator>().SetBool("cPlusWi", true);
        }

        if (request.GetComponent<customerRequest>().bPlusF)
        {
            GetComponent<Animator>().SetBool("bPlusF", true);
        }
        if (request.GetComponent<customerRequest>().bPlusW)
        {
            GetComponent<Animator>().SetBool("bPlusW", true);
        }
        if (request.GetComponent<customerRequest>().bPlusE)
        {
            GetComponent<Animator>().SetBool("bPlusE", true);
        }
        if (request.GetComponent<customerRequest>().bPlusWi)
        {
            GetComponent<Animator>().SetBool("bPlusWi", true);
        }

        if (request.GetComponent<customerRequest>().mPlusF)
        {
            GetComponent<Animator>().SetBool("mPlusF", true);
        }
        if (request.GetComponent<customerRequest>().mPlusW)
        {
            GetComponent<Animator>().SetBool("mPlusW", true);
        }
        if (request.GetComponent<customerRequest>().mPlusE)
        {
            GetComponent<Animator>().SetBool("mPlusE", true);
        }
        if (request.GetComponent<customerRequest>().mPlusWi)
        {
            GetComponent<Animator>().SetBool("mPlusWi", true);
        }

        if (request.GetComponent<customerRequest>().hPlusF)
        {
            GetComponent<Animator>().SetBool("hPlusF", true);
        }
        if (request.GetComponent<customerRequest>().hPlusW)
        {
            GetComponent<Animator>().SetBool("hPlusW", true);
        }
        if (request.GetComponent<customerRequest>().hPlusE)
        {
            GetComponent<Animator>().SetBool("hPlusE", true);
        }
        if (request.GetComponent<customerRequest>().hPlusWi)
        {
            GetComponent<Animator>().SetBool("hPlusWi", true);
        }
    }
}
