using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public Vector3 offset;
    public float smoothSpeed = 5f; 

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + player.transform.TransformDirection(offset);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);

            transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, Time.deltaTime * smoothSpeed);
        }
    }
}
