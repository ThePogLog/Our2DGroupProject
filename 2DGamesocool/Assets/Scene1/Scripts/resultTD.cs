using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultTD : MonoBehaviour
{
    [SerializeField]
    GameObject table1;
    [SerializeField]
    GameObject table2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (table1.GetComponent<tableTD>().active)
        {

        }

        if (table2.GetComponent<tableTD2>().active)
        {

        }
    }
}
