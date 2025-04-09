using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public int bulletsAmount;
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleFX;
    public AudioSource shootSound;
    public float fireRate;
    Animator animator;
    private void Awake() {
        animator = GetComponent<Animator>();
    }
    public void OnFire(InputValue value) {
        animator.SetBool("Shooting", value.isPressed);
        if (value.isPressed) {
            InvokeRepeating("Shoot", fireRate, fireRate);
        } 
        else {
            CancelInvoke();
        }
    }
    public void Shoot() {
        if (bulletsAmount > 0 && Time.timeScale > 0) {
            bulletsAmount--;
            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            muzzleFX.transform.position = shootPoint.transform.position;
            muzzleFX.transform.rotation = shootPoint.transform.rotation;
            muzzleFX.Play();

            shootSound.Play();
        }
    }
}
