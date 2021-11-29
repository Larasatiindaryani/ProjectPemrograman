using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform targetCamera;
    public float smoothSpeed = 0.2f;
    public Vector3 cameraoffset;
    void FixedUpdate(){
        Vector3 desiredPos = targetCamera.position + cameraoffset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position,desiredPos, smoothSpeed);
        transform.position = smoothedPos;
        transform.LookAt (targetCamera);
    }
}
