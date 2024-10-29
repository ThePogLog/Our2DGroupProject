using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerRequest : MonoBehaviour
{

    [SerializeField]
    GameObject result;
    [SerializeField]
    Animator anim;
    [SerializeField]
    int iWant = 0;

    [SerializeField]
    public bool youGotIt = false;

    [SerializeField]
   public bool cPlusF = false;
    [SerializeField]
    public bool cPlusW = false;
    [SerializeField]
    public bool cPlusWi = false;
    [SerializeField]
    public bool cPlusE = false;
    [SerializeField]
    public bool mPlusF = false;
    [SerializeField]
    public bool mPlusW = false;
    [SerializeField]
    public bool mPlusWi = false;
    [SerializeField]
    public bool mPlusE = false;
    [SerializeField]
    public bool bPlusF = false;
    [SerializeField]
    public bool bPlusW = false;
    [SerializeField]
    public bool bPlusWi = false;
    [SerializeField]
    public bool bPlusE = false;
    [SerializeField]
    public bool hPlusF = false;
    [SerializeField]
    public bool hPlusW = false;
    [SerializeField]
    public bool hPlusWi = false;
    [SerializeField]
    public bool hPlusE = false;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        int iWant = Random.Range(1, 16);

        if (iWant == 1)
        {
            cPlusF = true;
        }
        if (iWant == 2)
        {
            cPlusW = true;
        }
        if (iWant == 3)
        {
            cPlusWi = true;
        }
        if (iWant == 4)
        {
            cPlusE = true;
        }
        if (iWant == 5)
        {
            mPlusF = true;
        }
        if (iWant == 6)
        {
            mPlusW = true;
        }
        if (iWant == 7)
        {
            mPlusWi = true;
        }
        if (iWant == 8)
        {
            mPlusE = true;
        }
        if (iWant == 9)
        {
            bPlusF = true;
        }
        if (iWant == 10)
        {
            bPlusW = true;
        }
        if (iWant == 11)
        {
            bPlusWi = true;
        }
        if (iWant == 12)
        {
            bPlusE = true;
        }
        if (iWant == 13)
        {
            hPlusF = true;
        }
        if (iWant == 14)
        {
            hPlusW = true;
        }
        if (iWant == 15)
        {
            hPlusWi = true;
        }
        if (iWant == 16)
        {
            hPlusE = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cPlusF)
        {
            if (result.GetComponent<resultTD>().creaturesTotal && result.GetComponent<resultTD>().fireTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (cPlusW)
        {
            if (result.GetComponent<resultTD>().creaturesTotal && result.GetComponent<resultTD>().waterTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (cPlusWi)
        {
            if (result.GetComponent<resultTD>().creaturesTotal && result.GetComponent<resultTD>().windTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (cPlusE)
        {
            if (result.GetComponent<resultTD>().creaturesTotal && result.GetComponent<resultTD>().earthTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (bPlusF)
        {
            if (result.GetComponent<resultTD>().beastsTotal && result.GetComponent<resultTD>().fireTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (bPlusW)
        {
            if (result.GetComponent<resultTD>().beastsTotal && result.GetComponent<resultTD>().waterTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (bPlusWi)
        {
            if (result.GetComponent<resultTD>().beastsTotal && result.GetComponent<resultTD>().windTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (bPlusE)
        {
            if (result.GetComponent<resultTD>().beastsTotal && result.GetComponent<resultTD>().earthTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (mPlusF)
        {
            if (result.GetComponent<resultTD>().mineralsTotal && result.GetComponent<resultTD>().fireTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (mPlusW)
        {
            if (result.GetComponent<resultTD>().mineralsTotal && result.GetComponent<resultTD>().waterTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (mPlusWi)
        {
            if (result.GetComponent<resultTD>().mineralsTotal && result.GetComponent<resultTD>().windTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (mPlusE)
        {
            if (result.GetComponent<resultTD>().mineralsTotal && result.GetComponent<resultTD>().earthTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (hPlusF)
        {
            if (result.GetComponent<resultTD>().horrorsTotal && result.GetComponent<resultTD>().fireTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (hPlusW)
        {
            if (result.GetComponent<resultTD>().horrorsTotal && result.GetComponent<resultTD>().waterTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (hPlusWi)
        {
            if (result.GetComponent<resultTD>().horrorsTotal && result.GetComponent<resultTD>().windTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (hPlusE)
        {
            if (result.GetComponent<resultTD>().horrorsTotal && result.GetComponent<resultTD>().earthTotal && result.GetComponent<resultTD>().set)
            {
                youGotIt = true;
            }
            else
            {
                youGotIt = false;
            }
        }

        if (youGotIt)
        {
            GetComponent<Animator>().SetBool("yay", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("yay", false);
        }
    }
}
