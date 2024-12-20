using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 2.0f;
    public float bulletCooldown = 2.0f;
    public AudioClip shootSound;
    private bool isOnCooldown = false;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Input.GetButtonDown("Fire1") && !isOnCooldown)
            {
                StartCoroutine(Shoot());
            }
        }
    }

    IEnumerator Shoot()
    {
        isOnCooldown = true;

        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 shootDir = mousePosition - transform.position;
        shootDir.Normalize();
        bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;

        //Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
        Destroy(bullet, bulletLifetime);

        yield return new WaitForSeconds(bulletCooldown);

        isOnCooldown = false;
    }
}

