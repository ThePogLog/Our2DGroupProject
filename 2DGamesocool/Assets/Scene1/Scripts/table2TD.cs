using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class tableTD2 : MonoBehaviour
{

    [SerializeField]
    public bool active = false;
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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7)
        {
            active = true;
        }
        if (collision.gameObject.tag == "elementFire")
        {
            fire = true;
        }
        if (collision.gameObject.tag == "elementWater")
        {
            water = true;
        }
        if (collision.gameObject.tag == "elementEarth")
        {
            earth = true;
        }
        if (collision.gameObject.tag == "elementWind")
        {
            wind = true;
        }
        if (collision.gameObject.tag == "elementCreatures")
        {
            creatures = true;
        }
        if (collision.gameObject.tag == "elementBeasts")
        {
            beasts = true;
        }
        if (collision.gameObject.tag == "elementMinerals")
        {
            minerals = true;
        }
        if (collision.gameObject.tag == "elementHorrors")
        {
            horrors = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            active = false;
            fire = false;
            water = false;
            earth = false;
            wind = false;
            creatures = false;
            beasts = false;
            minerals = false;
            horrors = false;

        }
    }
}
