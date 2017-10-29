using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	// in Unity, we can define these member variables with drag and drop
	// so we can tweak restart delay time in inspector
	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel() {
		Debug.Log ("LEVEL WON!");
		completeLevelUI.SetActive (true);

	}

	public void EndGame() {
		if (!gameHasEnded) {
			gameHasEnded = true;
			Debug.Log ("GAME OVER");
			// Restart game
			// call method after restartDelay time
			Invoke("Restart", restartDelay);
		}
	}

	void Restart() {
		// actually fairly simple
		// LoadScene loads scene of specific name
		// GetActiceScene gives current scene (.name gives its name)
		// use this if you want to reload the same scene,
		// not necessarily some level 01 scene
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}
}
