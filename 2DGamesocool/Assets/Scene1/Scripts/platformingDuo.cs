using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformingDuo : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    [SerializeField]
    float jumpSpeed = 2f;
    bool grounded = false;
    bool selected = true;
    // Start is called before the first frame update
    void Start()
    {

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
            }
            else
            {
                selected = false;

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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = false;
        }
    }

}
