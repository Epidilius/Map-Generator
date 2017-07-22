using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Map pieces, bridge types, curved stuff would be cool 

public class MapGenV2 : MonoBehaviour {

    int TotalNumberOfZones = 4;
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
        foreach(GameObject zone in bridgeZoneCollection)
        {
            GenerateAreaFromBridgeZone(zone);
            Destroy(zone);
        }
        Destroy(bridgeZoneCollection);  //TODO: Will this delete all the child objects?
    }

    void GenerateAreaFromBridgeZone(GameObject aSourceZone)
    {
        var rand = Random.Range(0, TotalNumberOfZones);
        if(rand == 4)
        {
            //BaseZone
        } else
        {
            //Zone (rand)
        }
        //TODO: Pick a piece to make
        //TODO: Select a place to make it
        //TODO: Pick a zone on the piece
        //TODO: Position it
        //TODO: Check for map collisions
        //TODO: Spawn bridge
    }
}
