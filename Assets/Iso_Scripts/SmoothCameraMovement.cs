using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;
    public Vector2 minBounds;
    public Vector2 maxBounds;

    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        void Start()
        {
            // Hide the mouse cursor
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            Vector3 clampedPosition = new Vector3(
                Mathf.Clamp(targetPosition.x, minBounds.x, maxBounds.x),
                Mathf.Clamp(targetPosition.y, minBounds.y, maxBounds.y),
                targetPosition.z
            );

            transform.position = Vector3.SmoothDamp(transform.position, clampedPosition, ref velocity, damping);
        }
    }
}
