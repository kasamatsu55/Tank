using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class BulletController : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    
}
