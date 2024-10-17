using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class duoJumpscare : MonoBehaviour
{

    [SerializeField]
    GameObject throphy;

    [SerializeField]
    string levelToLoad = "winner";

    [SerializeField]
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       
        GetComponent<SpriteRenderer>().enabled = false;
        anim = GetComponent<Animator>();
        GetComponent<Animator>().SetBool("play", false);
    }

    private void Update()
    {
        StartCoroutine(portDelay());
    }

    // Update is called once per frame


    IEnumerator portDelay()
    {
        
            if (throphy.GetComponent<duoEndingTrigger>().jumpscareTime == true)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                GetComponent<Animator>().SetBool("play", true);

                yield return new WaitForSeconds(3);

                SceneManager.LoadScene(levelToLoad);
            }
        

    }
}
