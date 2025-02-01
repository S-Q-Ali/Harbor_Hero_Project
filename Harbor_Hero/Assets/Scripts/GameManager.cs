using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int coin;
    private int health;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI WonText;
    public TextMeshProUGUI LostText;

    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
        health = 100;
        CoinText.text = "Coins: " + coin;
        HealthText.text = "Health: " + health;
    }

    public void IncreaseCoins()
    {
           coin += 10;
           CoinText.text = "Coins: " + coin;
    }
    public void DecreaseHealth1()
    {
        health-=25;
        HealthText.text = "Health: " +health;
        if (health<= 0)
        {
            GameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void DecreaseHealth2()
    {
        health -= 10;
        HealthText.text = "Health: " + health;
        if (health <= 0)
        {
            GameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}