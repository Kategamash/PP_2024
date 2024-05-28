using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{ 
    [Header("Enemies")]
    public GameObject[] enemyTypes;
    public Transform[] enemySpawners;


    void Start()
    {
        foreach (Transform spawner in enemySpawners)
        {
            int rand = Random.Range(0, 101);
         
            if (rand < 30)
            {
                int intEnemy = Random.Range(0, enemyTypes.Length);
                GameObject enemyType = enemyTypes[intEnemy];
                Instantiate(enemyType, spawner.position, Quaternion.identity);
            }

        }
        
    }

}
