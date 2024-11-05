using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    int health = 10;
    [SerializeField]
    string levelToLoad;

    public Image healthBar;

    void Start()
    {
    }

    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        // Take damage if the player hits an enemy or enemy bullet
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullets")
        {
            health -= 1;
            UpdateHealthBar();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullets")
        {
            health -= 1;
            UpdateHealthBar();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        // Take damage if the player hits an enemy or enemy bullet
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullets")
        {
            health -= 1;
            UpdateHealthBar();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullets")
        {
            health -= 1;
            UpdateHealthBar();
        }
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = health / 10f; // Adjusting to ensure health is between 0 and 1
        if (health <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
