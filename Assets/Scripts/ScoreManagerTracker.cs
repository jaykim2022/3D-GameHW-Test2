using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerTracker : MonoBehaviour
{
    public int amount;
    public static ScoreManagerTracker instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Debug.LogError("Duplicated ScoreManager, ignoring this one", gameObject);
        }
    }
}
