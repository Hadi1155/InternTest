using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    void Awake()
    {
        Instance = this;  
    }
    
    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }

    public void IncreaseCoins(int value) // fitur agar game bisa menambahkan nilai pada text canvas 
    {
        currentCoins = currentCoins + value;
        coinText.text = "COINS: " + currentCoins.ToString();
    }
}
