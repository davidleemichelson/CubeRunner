using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {



	public void LoadNextLevel() {

		// Load scene of build index that equals
		// currently loaded scene + 1
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		// if we run out of scenes we'll get an error
	}
}
