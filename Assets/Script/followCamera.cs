using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class followCamera : MonoBehaviour
{
    public Transform TargetCamera;
    public float smoothSpeed;
    public Vector3 Offset;
    public Vector3 minValues, maxValue;

   
    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 positioncamera = TargetCamera.localPosition + Offset;
        Vector3 boundPosition = new Vector3(
            Mathf.Clamp(positioncamera.x,minValues.x,maxValue.x),
            Mathf.Clamp(positioncamera.y,minValues.y,maxValue.y),
            Mathf.Clamp(positioncamera.z,minValues.z,maxValue.z)
        );
        Vector3 smoothCamera = Vector3.Lerp(transform.position, boundPosition, smoothSpeed);
        transform.position = smoothCamera;
    }
}
