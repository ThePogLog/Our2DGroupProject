using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPortal : MonoBehaviour
{
    public GameObject prefab;

    void OnDestroy()
    {
        // Create the prefab at the position and rotation of this GameObject
        Instantiate(prefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
    }
}

