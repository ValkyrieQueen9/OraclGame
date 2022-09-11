using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform camTarget;
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        transform.position = camTarget.position;
    }

}
