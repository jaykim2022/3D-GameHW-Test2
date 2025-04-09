using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private Vector2 movementValue;
    private float lookValue;
    private Rigidbody rb;

    private void Awake() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value) {

        movementValue = value.Get<Vector2>() * speed;
        //Debug.Log("Move Input: " + movementValue);
    }
    public void OnLook(InputValue value) {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
        //Debug.Log("Move Input: " + movementValue);
    }
    void FixedUpdate() {
        //Debug.Log(movementValue.x);
        //transform.Translate(movementValue.x * Time.deltaTime,
        //0,
        //movementValue.y * Time.deltaTime);
        //Debug.Log(movementValue.y);

        //transform.Rotate(0, lookValue * Time.deltaTime, 0);

        //rb.AddRelativeForce(movementValue.x * Time.deltaTime,
        //0,
        //movementValue.y * Time.deltaTime);

        //rb.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);

        Vector3 move = transform.forward * movementValue.y + transform.right * movementValue.x;
        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z) * speed;

        // Rotation — smooth Y-axis turning
        Quaternion deltaRotation = Quaternion.Euler(0f, lookValue * rotationSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
