using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if (EnemiesManager.instance != null) 
        // {
        //     EnemiesManager.instance.enemies.Add(this);
        // }
        // else
        // {
        //     Debug.LogError("EnemiesManager instance is null!");
        // }
        if (EnemiesManager.instance != null)
        {
            EnemiesManager.instance.AddEnemy(this);
        }
        else
        {
            Debug.LogError("EnemiesManager instance is null. Ensure it exists in the scene.");
        }
    }

    void OnDestroy() {
        // if (EnemiesManager.instance != null) 
        // {
        //     EnemiesManager.instance.enemies.Remove(this);
        // }
        if (EnemiesManager.instance != null)
        {
            EnemiesManager.instance.RemoveEnemy(this);
        }
    }
}
