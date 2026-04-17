using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    public int coins = 100;
    public TMP_Text Coin;

    void Start()
    {
        UpdateCoinUI();
    }
    void UpdateCoinUI()
    {
        if (Coin == null) return;
        Coin.text = "" + coins;
    }

    public void AddCoin(int amount)
    {
        coins += amount;
        UpdateCoinUI();
    }

    public void SpendCoin(int amount)
    {
        coins -= amount;
        if(coins < 0 ) coins = 0;
        UpdateCoinUI();
    }


}