using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float followDistance = 4f;
    public float cameraSpeed = 3f;
    public LayerMask mask;

    private void LateUpdate()
    {
        float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * cameraSpeed;
        float newRotationY = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * cameraSpeed;

        if (newRotationY > 260 && newRotationY < 280)
            newRotationY = Mathf.Clamp(newRotationY, 300f, 360f);
        if (newRotationY > 80 && newRotationY < 90)
            newRotationY = Mathf.Clamp(newRotationY, 0f, 80f);
        
        Vector3 desiredRotation = new Vector3(newRotationY, newRotationX, 0f);
        transform.localEulerAngles = desiredRotation;

        float MaxfollowDistance = followDistance;
        if (Physics.SphereCast(target.position, .25f, -transform.forward, out RaycastHit hitInfo,
            followDistance, mask))
        {
            MaxfollowDistance = Mathf.Clamp(followDistance, 0, hitInfo.distance);
        }

        Vector3 desiredPosition = target.position - transform.forward * MaxfollowDistance;
        transform.position = desiredPosition;
    }
}
