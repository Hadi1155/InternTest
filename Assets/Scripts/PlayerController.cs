using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Transform bulletSpawnPoint;                          //Mendeklarasikan letak game objek yang dibutuhkan untuk mengeluarkan peluru player
    public float bulletSpeed;                                   //kecepatan peluru player
    public GameObject bulletPrefab;                             //Membuat slot untuk objek/prefab yang ingin digunakan sebagai peluru player
    public float moveSpeed, jumpPower, horizontalInput;         //Mendeklarasikan variabel yang penting untuk pergerakan player
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();           // untuk mendapatkan komponen RigidBody2D pada player, sehingga bisa digunakan untuk menggerakan player
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        Jump();
        Shoot();
    }

    void Jump()         // fitur untuk player agar bisa lompat
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }

    void Shoot()       // fitur player agar bisa menembak
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * bulletSpeed;
        }
    }
}
