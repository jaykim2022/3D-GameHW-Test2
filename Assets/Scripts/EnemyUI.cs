using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyUI : MonoBehaviour
{
    TMP_Text text;
    public EnemiesManager em;
    void Start() {
        text = GetComponent<TMP_Text>();
        //EnemiesManager.instance.onChanged.AddListener(RefreshText);
    }
     void Update() {
        text.text = "REMAINING ENEMIES: " + EnemiesManager.instance.enemies.Count;
    }
}
