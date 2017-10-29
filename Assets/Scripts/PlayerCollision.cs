using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;


	// Unity function for collisions
	// only want this to trigger when we hit a certain object
	void OnCollisionEnter(Collision collisionInfo) {
		// Code here is called whenever this object collides with something
		// Can add this script to whatever we want as long as we have
		// a rigid body and a collider

		// Collision.collider returns what collider what we hit
		// Collision.collider.name returns collider's name

		if (collisionInfo.collider.tag == "Obstacle") {
			movement.enabled = false;
			// using this instead of holding a variable
			// in use case of respawns (if we lose the object,
			// we lose the reference to GameManager)
			FindObjectOfType<GameManager>().EndGame();

		}

		// using tags to group items together; we'll use an obstacle tag

	}

}
