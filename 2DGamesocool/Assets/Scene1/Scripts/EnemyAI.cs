using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float chaseSpeed = 10f;
    [SerializeField]
    float chaseTriggerDistance = 5.0f;
    [SerializeField]
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the player gets too close
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDir = playerPosition - transform.position;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (chaseDir.magnitude < chaseTriggerDistance)
        {
            // Chase the player
            chaseDir.Normalize();
            rb.velocity = chaseDir * chaseSpeed;
        }
        else
        {
            // If the player is NOT close, stop moving
            rb.velocity = Vector3.zero;
        }

        // Determine the direction of movement for animation
        int x = 0; // Default to 0 (not moving)
        if (rb.velocity.x < 0)
        {
            x = -1;
        }
        else if (rb.velocity.x > 0)
        {
            x = 1;
        }

        anim.SetInteger("x", x);

        if (x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}

