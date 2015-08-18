using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

	//TODO: Check my notes on my phone
	//TODO: Public variables for number of x and z tiles
	//TODO: Public variables for the actual tiles. Try to figure out how to get at them progamatically though 

	// Use this for initialization
	void Start () {
		//TODO: Double for loop to generate the tiles
			//TODO: Random number generator to decide which of the prefabs to place
			//It will use a switch
	}
	
	// Update is called once per frame
	void Update () {
		//TODO: Delete update? No. Check if a bool (ccreateTile or something) is ture, and if is, create a tile
	}

	//TODO: Make the tile generator function. 
	//It should take in a prefab to place, and the current prefab the player is on (or the last placed one in the case of the Start() function)
}
