using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public float fill;

    void Start()
    {
        fill = 1f;
    }

    void Update()
    {
      /*  if (fill <= 0.0f)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MenuScene");
        }*/
        bar.fillAmount = fill;
        if(fill <= 1f && fill > 0.5f)
        {
            bar.color = Color.green;
        }
        if (fill <= 0.5f && fill >= 0.3f)
        {
            bar.color = Color.yellow;
        }
        if (fill < 0.3f && fill > 0.0f)
        {
            bar.color = Color.red;
        }
        fill -= System.Convert.ToSingle(Time.deltaTime * 0.1);
        bar.fillAmount = fill;
    }
}
