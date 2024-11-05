using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BossNull : MonoBehaviour
{
    public Tilemap fakewall;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnDestroy()
    {

            fakewall.GetComponent<TilemapRenderer>().enabled = false;
            fakewall.GetComponent<TilemapCollider2D>().enabled = false;



    }
}
