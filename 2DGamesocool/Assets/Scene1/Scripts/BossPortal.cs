using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPortal : MonoBehaviour
{
    public GameObject prefab;
    public GameObject boss;
    void Update()
    {
        if(boss == null)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);

        }
    }

  
}

