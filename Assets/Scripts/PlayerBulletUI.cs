using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBulletUI : MonoBehaviour
{
    TMP_Text text;
    public PlayerShooting targetShooting;
    void Awake() {
        text = GetComponent<TMP_Text>();
    }
    void Update()
    {
        text.text = "BULLETS: " + (targetShooting.bulletsAmount);
    }
}
