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

    [SerializeField]
    Animator anim;
    [SerializeField]
    bool tooMuch = false;
    [SerializeField]
    public bool set = false;

    [SerializeField]
    public bool fireTotal = false;
    [SerializeField]
    public bool waterTotal = false;
    [SerializeField]
    public bool earthTotal = false;
    [SerializeField]
    public bool windTotal = false;
    [SerializeField]
    public bool creaturesTotal = false;
    [SerializeField]
    public bool beastsTotal = false;
    [SerializeField]
    public bool mineralsTotal = false;
    [SerializeField]
    public bool horrorsTotal = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        GetComponent<Animator>().SetBool("tooMuch", false);

        GetComponent<Animator>().SetBool("fire", false);
        GetComponent<Animator>().SetBool("water", false);
        GetComponent<Animator>().SetBool("wind", false);
        GetComponent<Animator>().SetBool("earth", false);

        GetComponent<Animator>().SetBool("creatures", false);
        GetComponent<Animator>().SetBool("minerals", false);
        GetComponent<Animator>().SetBool("beasts", false);
        GetComponent<Animator>().SetBool("horrors", false);

        GetComponent<Animator>().SetBool("set", false);
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
        if (fire || fire2)
        {

            GetComponent<Animator>().SetBool("fire", true);
            fireTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("fire", false);
            fireTotal = false;
        }
        if (water || water2)
        {

            GetComponent<Animator>().SetBool("water", true);
            waterTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("water", false);
            waterTotal = false;
        }

        if (wind || wind2)
        {

            GetComponent<Animator>().SetBool("wind", true);
            windTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("wind", false);
            windTotal = false;
        }
        if (earth || earth2)
        {

            GetComponent<Animator>().SetBool("earth", true);
            earthTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("earth", false);
            earthTotal = false;
        }


        if (creatures || creatures2)
        {

            GetComponent<Animator>().SetBool("creatures", true);
            creaturesTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("creatures", false);
            creaturesTotal = false;
        }
        if (beasts || beasts2)
        {

            GetComponent<Animator>().SetBool("beasts", true);
            beastsTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("beasts", false);
            beastsTotal = false;
        }

        if (minerals || minerals2)
        {

            GetComponent<Animator>().SetBool("minerals", true);
            mineralsTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("minerals", false);
            mineralsTotal = false;
        }
        if (horrors || horrors2)
        {

            GetComponent<Animator>().SetBool("horrors", true);
            horrorsTotal = true;
        }
        else
        {

            GetComponent<Animator>().SetBool("horrors", false);
            horrorsTotal = false;
        }
         
        if (fireTotal && creaturesTotal)
        {
            if (!waterTotal && !windTotal && !earthTotal && !beastsTotal && !mineralsTotal && !horrorsTotal)
            {
                set = true;
                tooMuch = false;
            }
            else
            {
             tooMuch = true;
            set = false; 
            }
        }
        else
        {
            if (fireTotal && beastsTotal)
            {
                if (!waterTotal && !windTotal && !earthTotal && !creaturesTotal && !mineralsTotal && !horrorsTotal)
                {
                    set = true;
                    tooMuch = false;
                }
                else
                {
                    tooMuch = true;
                    set = false;
                }
            }
            else
            {
                if (fireTotal && mineralsTotal)
                {
                    if (!waterTotal && !windTotal && !earthTotal && !creaturesTotal && !beastsTotal && !horrorsTotal)
                    {
                        set = true;
                        tooMuch = false;
                    }
                    else
                    {
                        tooMuch = true;
                        set = false;
                    }
                }
                else
                {
                    if (fireTotal && horrorsTotal)
                    {
                        if (!waterTotal && !windTotal && !earthTotal && !creaturesTotal && !beastsTotal && !mineralsTotal)
                        {
                            set = true;
                            tooMuch = false;
                        }
                        else
                        {
                            tooMuch = true;
                            set = false;
                        }
                    }
                    else
                    {
                        if (waterTotal && creaturesTotal)
                        {
                            if (!fireTotal && !windTotal && !earthTotal && !beastsTotal && !mineralsTotal && !horrorsTotal)
                            {
                                set = true;
                                tooMuch = false;
                            }
                            else
                            {
                                tooMuch = true;
                                set = false;
                            }
                        }
                        else
                        {
                            if (waterTotal && beastsTotal)
                            {
                                if (!fireTotal && !windTotal && !earthTotal && !creaturesTotal && !mineralsTotal && !horrorsTotal)
                                {
                                    set = true;
                                    tooMuch = false;
                                }
                                else
                                {
                                    tooMuch = true;
                                    set = false;
                                }
                            }
                            else
                            {
                                if (waterTotal && mineralsTotal)
                                {
                                    if (!fireTotal && !windTotal && !earthTotal && !creaturesTotal && !beastsTotal && !horrorsTotal)
                                    {
                                        set = true;
                                        tooMuch = false;
                                    }
                                    else
                                    {
                                        tooMuch = true;
                                        set = false;
                                    }
                                }
                                else
                                {
                                    if (waterTotal && horrorsTotal)
                                    {
                                        if (!fireTotal && !windTotal && !earthTotal && !creaturesTotal && !beastsTotal && !mineralsTotal)
                                        {
                                            set = true;
                                            tooMuch = false;
                                        }
                                        else
                                        {
                                            tooMuch = true;
                                            set = false;
                                        }
                                    }
                                    else
                                    {
                                        if (windTotal && creaturesTotal)
                                        {
                                            if (!waterTotal && !fireTotal && !earthTotal && !beastsTotal && !mineralsTotal && !horrorsTotal)
                                            {
                                                set = true;
                                                tooMuch = false;
                                            }
                                            else
                                            {
                                                tooMuch = true;
                                                set = false;
                                            }
                                        }
                                        else
                                        {
                                            if (windTotal && beastsTotal)
                                            {
                                                if (!waterTotal && !fireTotal && !earthTotal && !creaturesTotal && !mineralsTotal && !horrorsTotal)
                                                {
                                                    set = true;
                                                    tooMuch = false;
                                                }
                                                else
                                                {
                                                    tooMuch = true;
                                                    set = false;
                                                }
                                            }
                                            else
                                            {
                                                if (windTotal && mineralsTotal)
                                                {
                                                    if (!waterTotal && !fireTotal && !earthTotal && !creaturesTotal && !beastsTotal && !horrorsTotal)
                                                    {
                                                        set = true;
                                                        tooMuch = false;
                                                    }
                                                    else
                                                    {
                                                        tooMuch = true;
                                                        set = false;
                                                    }
                                                }
                                                else
                                                {
                                                    if (windTotal && horrorsTotal)
                                                    {
                                                        if (!waterTotal && !fireTotal && !earthTotal && !creaturesTotal && !beastsTotal && !mineralsTotal)
                                                        {
                                                            set = true;
                                                            tooMuch = false;
                                                        }
                                                        else
                                                        {
                                                            tooMuch = true;
                                                            set = false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (earthTotal && creaturesTotal)
                                                        {
                                                            if (!fireTotal && !windTotal && !waterTotal && !beastsTotal && !mineralsTotal && !horrorsTotal)
                                                            {
                                                                set = true;
                                                                tooMuch = false;
                                                            }
                                                            else
                                                            {
                                                                tooMuch = true;
                                                                set = false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (earthTotal && beastsTotal)
                                                            {
                                                                if (!fireTotal && !windTotal && !waterTotal && !creaturesTotal && !mineralsTotal && !horrorsTotal)
                                                                {
                                                                    set = true;
                                                                    tooMuch = false;
                                                                }
                                                                else
                                                                {
                                                                    tooMuch = true;
                                                                    set = false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (earthTotal && mineralsTotal)
                                                                {
                                                                    if (!fireTotal && !windTotal && !waterTotal && !creaturesTotal && !beastsTotal && !horrorsTotal)
                                                                    {
                                                                        set = true;
                                                                        tooMuch = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        tooMuch = true;
                                                                        set = false;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (earthTotal && horrorsTotal)
                                                                    {
                                                                        if (!fireTotal && !windTotal && !waterTotal && !creaturesTotal && !beastsTotal && !mineralsTotal)
                                                                        {
                                                                            set = true;
                                                                            tooMuch = false;
                                                                        }
                                                                        else
                                                                        {
                                                                            tooMuch = true;
                                                                            set = false;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        set = false;
                                                                        tooMuch = false;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        if (set)
        {
            GetComponent<Animator>().SetBool("set", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("set", false);
        }

        if (tooMuch)
        {
            GetComponent<Animator>().SetBool("tooMuch", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("tooMuch", false);

        }

    }
}
