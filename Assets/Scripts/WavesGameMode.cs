using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] Life playerLife;
    [SerializeField] Life playerBaseLife;


    // Update is called once per frame
    // void Update()
    // {
    //     if (EnemiesManager.instance == null)
    //     {
    //         Debug.LogError("EnemiesManager instance is null.");
    //         return;
    //     }

    //     if (WavesManager.instance == null)
    //     {
    //         Debug.LogError("WavesManager instance is null.");
    //         return;
    //     }

    //     if (playerLife == null)
    //     {
    //         Debug.LogError("playerLife is null.");
    //         return;
    //     }
    //     if (EnemiesManager.instance.enemies.Count <= 0 &&
    //     WavesManager.instance.waves.Count <= 0) {
    //         SceneManager.LoadScene("WinScreen");
    //         //print("win");
    //     }
    //     // if (playerLife.amount <= 0) {
    //     //     SceneManager.LoadScene("LoseScreen");
    //     //     //print("lose");
    //     // }
    // }
    void Start() {
        playerLife.onDeath.AddListener(OnPlayerOrbaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrbaseDied);

        if (EnemiesManager.instance == null) {
            Debug.LogError("EnemiesManager instance is null. Ensure it exists in the scene.");
            return;
        }
        if (WavesManager.instance == null) {
            Debug.LogError("WavesManager instance is null. Ensure it exists in the scene.");
            return;
        }
        EnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);
    }
    void OnPlayerOrbaseDied() {
        SceneManager.LoadScene("LoseScreen");
    }
    void CheckWinCondition() {
        if (EnemiesManager.instance.enemies.Count <= 0 && WavesManager.instance.waves.Count <= 0) {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
