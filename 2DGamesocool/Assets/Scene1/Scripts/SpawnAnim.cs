using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnim : MonoBehaviour
{
    [SerializeField]
    bool spawned = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnDelay()
    {
        spawned = true;
        yield return new WaitForSeconds(4);
        spawned = false;
    }
}
