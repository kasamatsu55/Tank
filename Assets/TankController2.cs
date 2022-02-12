using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController2 : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            StartCoroutine(Fire());
        }
        float rot = Input.GetAxis("Horizontal");
        float acc = Input.GetAxis("Vertical");
        transform.Rotate(0, rot, 0);
        transform.Translate(0, 0, acc * 0.1f);
    }
    IEnumerator Fire()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject obj = Instantiate(
            prefab,
            transform.position + transform.forward * 2.4f + transform.up * 0.7f,
            Quaternion.LookRotation(transform.forward)
        );

        obj.GetComponent<Rigidbody>().velocity = transform.forward * 80.0f;
    }
}
