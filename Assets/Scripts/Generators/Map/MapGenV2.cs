using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Map pieces, bridge types, curved stuff would be cool 

public class MapGenV2 : MonoBehaviour {

    int TotalNumberOfZones = 4;
    int TotalNumberOfBridges = 3;
    //TODO: Make an enum or something of types, then an int of each type

	// Use this for initialization
	void Start () {
		//TODO: Generate ares of start zone
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateNearbyZones()
    {
        var bridgeZoneCollection = transform.Find("BridgeZones");
        foreach(Transform zone in bridgeZoneCollection)
        {
            GenerateAreaFromBridgeZone(zone.gameObject);
        }
        Destroy(bridgeZoneCollection.gameObject); 
    }

    void GenerateAreaFromBridgeZone(GameObject aSourceZone)
    {
        var zone = PickZone();
        var bridge = PickBridge();

        PositionBridge(bridge, aSourceZone);
        PositionZone(bridge.transform.Find("BridgeZones").transform.Find("Bridge Zone (1)").gameObject, zone);
    }

    GameObject PickZone()
    {
        var rand = Random.Range(0, TotalNumberOfZones);
        GameObject zone;
        if (rand == TotalNumberOfZones - 1)
        {
            //BaseZone
            zone = Instantiate(Resources.Load("Map/Zones/BaseZone") as GameObject);
        }
        else
        {
            //Zone (rand)
            zone = Instantiate(Resources.Load("Map/Zones/Zone (" + rand+ ")") as GameObject);
        }

        return zone;
    }

    GameObject PickBridge()
    {
        var rand = Random.Range(0, TotalNumberOfBridges);
        GameObject bridge = Instantiate(Resources.Load("Map/Bridges/Bridge (" + rand + ")") as GameObject);
        return bridge;
    }

    void PositionBridge(GameObject aBridge, GameObject aSourceZone)
    {
        var bridgeZones = aBridge.transform.Find("BridgeZones");
        var startPoint = aSourceZone.transform.position;
        var rotation = Quaternion.LookRotation((aSourceZone.transform.position - aSourceZone.transform.parent.position).normalized);

        bridgeZones.transform.Find("Bridge Zone (0)").SetPositionAndRotation(startPoint, rotation);
    }

    void PositionZone(GameObject aBridgeEnd, GameObject aZone)
    {
        var startPoint = aBridgeEnd.transform.position;
        var bridgeZones = aZone.transform.Find("BridgeZones");
        var bridgeZoneID = Random.Range(0, bridgeZones.childCount);
        var bzToConnectTo = bridgeZones.Find("Bridge Zone (" + bridgeZoneID + ")");
        var rotation = Quaternion.LookRotation((bzToConnectTo.position - aBridgeEnd.transform.position).normalized);

        var offset = bzToConnectTo.parent.parent.position - bzToConnectTo.position;
        var endPoint = startPoint - offset;
        bzToConnectTo.parent.parent.SetPositionAndRotation(endPoint, rotation);
    }
}
