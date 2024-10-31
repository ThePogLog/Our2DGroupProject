using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour
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
        if (collision.gameObject.name != "Orb_0(Clone)" && collision.gameObject.tag != "Player")
        {
            Destroy(this.gameObject);
        }
    }
}

