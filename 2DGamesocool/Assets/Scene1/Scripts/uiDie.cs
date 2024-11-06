using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiDie : MonoBehaviour
{
    [SerializeField]
    GameObject throphy;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(portDelay());
    }

    IEnumerator portDelay()
    {

        if (throphy.GetComponent<duoEndingTrigger>().jumpscareTime == true)
        {
            GetComponent<Canvas>().enabled = false;


            yield return new WaitForSeconds(3);


        }


    }
}

