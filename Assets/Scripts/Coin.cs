using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int coinValue = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) // untuk membaca adanya gaya tabrakan yang nantinya akan menghilang dan menambahkan value coin pada player
        {
            Destroy(gameObject);
            CoinCounter.Instance.IncreaseCoins(coinValue);
        }
    }
}
