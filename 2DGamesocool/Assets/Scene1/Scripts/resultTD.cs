using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultTD : MonoBehaviour
{
    [SerializeField]
    GameObject table1;
    [SerializeField]
    GameObject table2;
    [SerializeField]
    bool getCooken = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (table1.GetComponent<tableTD>().active && table2.GetComponent<tableTD2>().active)
        {
            getCooken = true;
        }
        else
        {
            getCooken = false;
        }

    }
}
