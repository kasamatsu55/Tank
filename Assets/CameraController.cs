using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform tank;
    public float dist = 3.5f;
    public float height = 1.5f;

    void LateUpdate()
    {
        transform.position = tank.position + (-tank.forward * dist) + tank.up * height;
        transform.LookAt(tank.position);
    }
}
