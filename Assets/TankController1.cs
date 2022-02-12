using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController1 : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(x, 0f, z);

        if(dir.magnitude > 0.1)
        {
            transform.LookAt(transform.position + dir);
            rb.velocity = transform.forward * 5.0f;
        }
    }
}
