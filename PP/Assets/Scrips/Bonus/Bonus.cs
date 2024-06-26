using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bonus : MonoBehaviour
{
    public string bonusName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            switch(bonusName)
            {
                case "coin":
                    int coins = PlayerPrefs.GetInt("coins");
                    PlayerPrefs.SetInt("coins", coins + 1);
                    CoinCounter.Instance.SetCoinCount(coins + 1);
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
