using UnityEngine;
using System.Collections;

public class DestroyBullet1 : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "EnemyBullets" && collision.gameObject.tag != "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}

