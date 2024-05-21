using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        fill -= System.Convert.ToSingle(Time.deltaTime * 0.1);
        bar.fillAmount = fill;
    }
}
