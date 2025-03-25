using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleFX;
    public void OnFire(InputValue value) {
        if (value.isPressed) {
            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            muzzleFX.transform.position = shootPoint.transform.position;
            muzzleFX.transform.rotation = shootPoint.transform.rotation;
            muzzleFX.Play();
        }
    }
}
