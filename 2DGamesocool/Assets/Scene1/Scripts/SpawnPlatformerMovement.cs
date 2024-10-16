using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class PlatformerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 2f;
    bool grounded = false;
    bool spawned = true;
    [SerializeField] Animator anim;
    public Canvas CubeHUD;
    public Tilemap Fake;
    public Grid Wall;
    public Tilemap Dark1;
    public Tilemap Dark2;
    public Tilemap Dark3;
    public GameObject OFDroid1;
    public GameObject OFDroid2;
    public GameObject OFDroid3;
    public GameObject OFDroid4;
    public GameObject OFDroid5;
    public GameObject OFDroid6;

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(SpawnDelay());
        CubeHUD.enabled = false;
    }

    void Update()
    {
        if (spawned) return;

        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }

        anim.SetBool("spawned", spawned);
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

    IEnumerator SpawnDelay()
    {
        CubeHUD.enabled = false;
        Wall.enabled = false;
        yield return new WaitForSeconds(5);
        Wall.enabled = true;
        OFDroid1.GetComponent<SpriteRenderer>().color = Color.white;
        OFDroid2.GetComponent<SpriteRenderer>().color = Color.white;
        OFDroid3.GetComponent<SpriteRenderer>().color = Color.white;
        OFDroid4.GetComponent<SpriteRenderer>().color = Color.white;
        OFDroid5.GetComponent<SpriteRenderer>().color = Color.white;
        OFDroid6.GetComponent<SpriteRenderer>().color = Color.white;
        Fake.GetComponent<TilemapRenderer>().enabled = false;
        Dark1.GetComponent<TilemapRenderer>().enabled = false;
        Dark2.GetComponent<TilemapRenderer>().enabled = false;
        Dark3.GetComponent<TilemapRenderer>().enabled = false;
        CubeHUD.enabled = true;
        spawned = true;
        yield return new WaitForSeconds(1);
        spawned = false;
    }
}
