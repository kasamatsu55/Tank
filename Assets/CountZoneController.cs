using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountZoneController : MonoBehaviour
{
    public GameManager gm;

    void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "Block")
        {
            gm.AddCount();
        }
    }
}
