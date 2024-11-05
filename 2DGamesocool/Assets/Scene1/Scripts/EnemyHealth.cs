using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] Color Damagecolorpicker;
    [SerializeField] float Colortimer;
    [SerializeField] Color ColorOriginal;

    void Start()
    {
        ColorOriginal = GetComponent<SpriteRenderer>().color; // Save the original color

    }

    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {
            StartCoroutine(Damage(collision)); // Start the coroutine on collision
        }
    }

    IEnumerator Damage(Collider2D collision)
    {
        // health = health - 1;
        health -= 1;
        gameObject.GetComponent<SpriteRenderer>().color = Damagecolorpicker;
        yield return new WaitForSeconds(Colortimer);
        gameObject.GetComponent<SpriteRenderer>().color = ColorOriginal;
        // health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}