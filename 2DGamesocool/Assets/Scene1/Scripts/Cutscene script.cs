using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneScript : MonoBehaviour
{
    public Canvas text1; // Assign this in the Inspector

    void Start()
    {
        text1.enabled = false; // Disable text1 Canvas at the start
    }

    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(SpawnDelay());
        }
    }

    IEnumerator SpawnDelay()
    {
        text1.enabled = true;
        yield return new WaitForSeconds(2);
        text1.enabled = false;
    }
}
