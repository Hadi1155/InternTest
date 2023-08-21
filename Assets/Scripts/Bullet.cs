using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) //fitur untuk menghilangkan object ketika sudah tabrakan dengan gameobjek lainnya
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
