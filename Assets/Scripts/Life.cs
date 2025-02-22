using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    public float amount;
    public UnityEvent onDeath;
    bool isDead = false;

    void Update() {
        if (amount <= 0 && !isDead) {
            Die();
        }
    }
    void Die()
{
    isDead = true;
    onDeath.Invoke();
    Destroy(gameObject);
}
}
