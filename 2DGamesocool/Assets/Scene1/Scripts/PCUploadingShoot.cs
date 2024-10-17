using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCUploadingShoot : MonoBehaviour
{
    public GameObject The1;
    public GameObject The2;
    public GameObject The3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
    }
    IEnumerator SpawnDelay()
    {
        if (gameObject.tag == "Player")
        {
            The1.GetComponent<SpriteRenderer>().enabled = false;
            The2.GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(7);
            The2.GetComponent<SpriteRenderer>().enabled = false;
            The3.GetComponent<SpriteRenderer>().enabled = true;
        }

    }

}
