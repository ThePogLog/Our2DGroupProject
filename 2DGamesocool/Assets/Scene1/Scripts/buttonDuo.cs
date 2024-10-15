using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonDuo : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    public bool pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
  
        if (collision.gameObject.tag == "duoBox")
        {
            pressed = true;
            GetComponent<Animator>().SetBool("pressed", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "duoBox")
        {
            pressed = false;
            GetComponent<Animator>().SetBool("pressed", false);
        }
    }
}
