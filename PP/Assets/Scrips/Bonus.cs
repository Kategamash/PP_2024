using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public string bonusName;

    public Text coinCount;

    void Awake()
    {
        coinCount.text = PlayerPrefs.GetInt("coins").ToString();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            switch(bonusName)
            {
                case "coin":
                    int coins = PlayerPrefs.GetInt("coins");
                    PlayerPrefs.SetInt("coins", coins + 1);
                    coinCount.text = (coins + 1).ToString();
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
