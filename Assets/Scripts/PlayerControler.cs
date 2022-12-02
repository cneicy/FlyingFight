using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public GameObject bulletPrefab;
    public float fireRate = 0.01f;
    public float nextFire = 0f;
    private void Start()
    {
        
    }
    void Update()
    {
        Movement();
        if (Input.GetKey(KeyCode.Z))
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(bulletPrefab, transform.position, transform.rotation);
            }
        }
    }
    void Movement()
    {
        rb.velocity = new Vector2(0, 0);
        float horizontalmove = Input.GetAxis("Horizontal");
        float verticalmove = Input.GetAxis("Vertical");
        if (horizontalmove != 0|| verticalmove != 0)
        {
            rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);
            rb.velocity = new Vector2(rb.velocity.x, verticalmove * speed);
        }
    }
}
