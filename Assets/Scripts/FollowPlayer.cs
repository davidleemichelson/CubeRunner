using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// variable storing reference to our player
	// Transform component: position, rotation, and scale 
	public Transform player;
	public Vector3 offset; // (a,b,c) stores 3 floats (good for positional data x,y,z)
	 
	// Update is called once per frame
	void Update () {
		// set self's transform component's position to the same position
		// as the player's transform component's position

		// vector addition
		// x player + x offset; y player + y offset; z player + z offset
		transform.position = player.position + offset;
	}
}
