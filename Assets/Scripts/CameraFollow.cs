using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 4.0f;
    public float height = 4.0f;

    private Vector3 offset;

    void Start()
    {
        offset = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
