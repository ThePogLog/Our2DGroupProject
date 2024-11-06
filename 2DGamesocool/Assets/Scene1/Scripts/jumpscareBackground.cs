using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpscareBackground : MonoBehaviour
{

    [SerializeField]
    GameObject throphy;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(portDelay());
    }

    IEnumerator portDelay()
    {

        if (throphy.GetComponent<duoEndingTrigger>().jumpscareTime == true)
        {
            GetComponent<SpriteRenderer>().enabled = true;


            yield return new WaitForSeconds(3);

     
        }


    }
}
