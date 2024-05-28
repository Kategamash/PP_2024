using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter Instance { get; private set; }

    public Text _coinCount;

    private void Awake()
    {
        Instance = this;
    }

    public void SetCoinCount(int coinCount)
    {
        Debug.Log(coinCount.ToString());

        _coinCount.text = coinCount.ToString();
    }
}
