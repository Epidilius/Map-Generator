using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCreationTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.parent.transform.parent.GetComponent<MapGenV2>().GenerateNearbyZones();
        }
    }
}
