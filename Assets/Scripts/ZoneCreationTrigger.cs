using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCreationTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Bridge Collision, creating zones");
            this.transform.parent.GetComponent<MapGenV2>().GenerateNearbyZones();
        }
    }
}
