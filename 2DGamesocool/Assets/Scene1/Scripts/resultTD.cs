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
    [SerializeField]
    public bool fire = false;
    [SerializeField]
    public bool water = false;
    [SerializeField]
    public bool earth = false;
    [SerializeField]
    public bool wind = false;
    [SerializeField]
    public bool creatures = false;
    [SerializeField]
    public bool beasts = false;
    [SerializeField]
    public bool minerals = false;
    [SerializeField]
    public bool horrors = false;
    [SerializeField]
    public bool fire2 = false;
    [SerializeField]
    public bool water2 = false;
    [SerializeField]
    public bool earth2 = false;
    [SerializeField]
    public bool wind2 = false;
    [SerializeField]
    public bool creatures2 = false;
    [SerializeField]
    public bool beasts2 = false;
    [SerializeField]
    public bool minerals2 = false;
    [SerializeField]
    public bool horrors2 = false;
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

        if (getCooken)
        {
            if (table1.GetComponent<tableTD>().fire)
            {
                fire = true;
            }
            else
            {
                fire = false;
            }
            if (table1.GetComponent<tableTD>().water)
            {
                water = true;
            }
            else
            {
                water = false;
            }
            if (table1.GetComponent<tableTD>().wind)
            {
                wind = true;
            }
            else
            {
                wind = false;
            }
            if (table1.GetComponent<tableTD>().earth)
            {
                earth = true;
            }
            else
            {
                earth = false;
            }
            if (table1.GetComponent<tableTD>().creatures)
            {
               creatures = true;
            }
            else
            {
                creatures = false;
            }
            if (table1.GetComponent<tableTD>().beasts)
            {
                beasts = true;
            }
            else
            {
                beasts = false;
            }
            if (table1.GetComponent<tableTD>().minerals)
            {
                minerals = true;
            }
            else
            {
                minerals = false;
            }
            if (table1.GetComponent<tableTD>().horrors)
            {
                horrors = true;
            }
            else
            {
                horrors = false;
            }

            if (table2.GetComponent<tableTD2>().fire)
            {
                fire2 = true;
            }
            else
            {
                fire2 = false;
            }
            if (table2.GetComponent<tableTD2>().water)
            {
                water2 = true;
            }
            else
            {
                water2 = false;
            }
            if (table2.GetComponent<tableTD2>().wind)
            {
                wind2 = true;
            }
            else
            {
                wind2 = false;
            }
            if (table2.GetComponent<tableTD2>().earth)
            {
                earth2 = true;
            }
            else
            {
                earth2 = false;
            }
            if (table2.GetComponent<tableTD2>().creatures)
            {
                creatures2 = true;
            }
            else
            {
                creatures2 = false;
            }
            if (table2.GetComponent<tableTD2>().beasts)
            {
                beasts2 = true;
            }
            else
            {
                beasts2 = false;
            }
            if (table2.GetComponent<tableTD2>().minerals)
            {
                minerals2 = true;
            }
            else
            {
                minerals2 = false;
            }
            if (table2.GetComponent<tableTD2>().horrors)
            {
                horrors2 = true;
            }
            else
            {
                horrors2 = false;
            }
        }
        else
        {
            fire = false;
            water = false;
            earth = false;
            wind = false;
            creatures = false;
            beasts = false;
            minerals = false;
            horrors = false;

            fire2 = false;
            water2 = false;
            earth2 = false;
            wind2 = false;
            creatures2 = false;
            beasts2 = false;
            minerals2 = false;
            horrors2 = false;
        }


    }
}
