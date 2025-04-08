using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WavesUI : MonoBehaviour
{
    TMP_Text text;
    void Start() {
        text = GetComponent<TMP_Text>();
        EnemiesManager.instance.onChanged.AddListener(RefreshText);
    }
     void RefreshText() {
        text.text = "REMAINING WAVES: " + WavesManager.instance.waves.Count;
    }
}

