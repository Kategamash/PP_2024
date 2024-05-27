using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 1f;

    public void SavePlayer()
    {
        SaveSistem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerDataSV data = SaveSistem.LoadPlayer();

        health = data.health;

        Vector3 position;

        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }
}
