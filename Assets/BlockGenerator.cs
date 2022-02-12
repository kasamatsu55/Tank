using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateBlock());
    }

    IEnumerator CreateBlock()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(
                prefab,
                new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(3.0f, 10.0f), Random.Range(0.0f, 10.0f)),
                Quaternion.Euler(Random.insideUnitSphere * 360f)
            );
            yield return new WaitForSeconds(0.01f);
        }
    }
}
