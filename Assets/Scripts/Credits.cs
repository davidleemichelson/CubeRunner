using UnityEngine;

public class Credits : MonoBehaviour {

	// button onclick needs to be public
	public void Quit() {
		Debug.Log ("Quit");
		Application.Quit ();
	}
}
