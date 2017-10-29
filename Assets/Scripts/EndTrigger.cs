using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter() {
		// so, need reference to game manager
		// tell gamemanager to display UI on screen
			
		gameManager.CompleteLevel();

		// TODO: CHECK IF THE PLAYER IS THE ONE THAT COLLIDED
		// DON'T COMPLETE LEVEL IF NOT THE PLAYER THAT COLLIDED
	}

}
