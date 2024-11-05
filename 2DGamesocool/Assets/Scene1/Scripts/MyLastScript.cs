using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MyLastScript : MonoBehaviour
{
    [SerializeField]
    string levelToLoad;
    public Camera yes;
    public float Seconds;
    public float Wait;
    public float almost;
    public Canvas destroy;
    public Canvas canvas;
    public Canvas canvas2;
    public Canvas canvas3;
    public Canvas canvas4;
    public Canvas canvas5;
        
    public Canvas canvas6;
    public Canvas canvas7;
        
    public Canvas canvas8;
    public Canvas canvas9;
    public Canvas canvas10;
    public NewPlatformerMovement script;
    public GameObject player;
    public GameObject coffee;
    public GameObject trophy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Cutscene());

    }

    IEnumerator Cutscene()
    {
        script.enabled = false;
        destroy.enabled = false;
        yield return new WaitForSeconds(Wait);
        player.GetComponent<SpriteRenderer>().enabled = false;
        coffee.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(almost);
        trophy.GetComponent<SpriteRenderer>().enabled = true;
        yes.GetComponent<Camera>().backgroundColor = Color.black;
        canvas.enabled = true;
        yield return new WaitForSeconds(Seconds);
        canvas2.enabled = true;
        yield return new WaitForSeconds(Seconds);
        canvas3.enabled = true;
        yield return new WaitForSeconds(Seconds);
        canvas4.enabled = true;
            
        yield return new WaitForSeconds(Seconds);
            
        canvas5.enabled = true;
        yield return new WaitForSeconds(Seconds);
        canvas6.enabled = true;
        yield return new WaitForSeconds(Seconds);
        canvas7.enabled = true;
        yield return new WaitForSeconds(Seconds);
            
        canvas8.enabled = true;
            
        yield return new WaitForSeconds(Seconds);
        canvas9.enabled = true;
        yield return new WaitForSeconds(Seconds);
        canvas10.enabled = true;
        SceneManager.LoadScene(levelToLoad);

    }


}
