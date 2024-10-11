using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class platformingDuo : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    [SerializeField]
    float jumpSpeed = 2f;
    bool grounded = false;
    bool selected = true;
    [SerializeField]
    Animator anim;
    [SerializeField]
    string levelToLoad = "winner";
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("selected", true);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (selected == false)
            {
                selected = true;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                GetComponent<Animator>().SetBool("selected", true);
            }
            else
            {
                selected = false;
                GetComponent<Animator>().SetBool("selected", false);
            }
        }

        if (selected == true)
        {
            float moveX = Input.GetAxis("Horizontal");
            Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
            velocity.x = moveX * moveSpeed;
            GetComponent<Rigidbody2D>().velocity = velocity;
            //need to find a way to know if we are on the ground
            if (Input.GetButtonDown("Jump") && grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
                grounded = false;
            }
            anim.SetBool("grounded", grounded);
            anim.SetFloat("y", velocity.y);
            int x = (int)Input.GetAxisRaw("Horizontal");
            anim.SetInteger("x", x);
            if (x < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else if (x > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;

            }
        }

        if (selected == false)
        {

            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = true;
        }

        if (collision.gameObject.tag == "portal")
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = false;
        }
    }

   

}
