using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	// if you use a variable name you can modify it in Unity inspector
	public float forwardForce = 2000f; 
	public float sidewaysForce = 500f;

	// Update is called once per frame

	// if calculating physics when you update, use FixedUpdate
	void FixedUpdate () {
		// Time.deltaTime used to account for different framerates

		// Add a forward force (can edit in inspector because forwardForce variable)
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);	

		// Not the most efficient player movement way
		// 2 problems:
		// 1) way we're getting player input
		// smoothing, alternative keys, controller? unity has better ways
		// 2) checking input in FixedUpdate
		// ok since it's mainly movement which is smooth
		// not ok for stuff like jumping or other one-off events
		// if fixedupdate runs slower, then we might miss player input
		// because we only get input in the update function
		if (Input.GetKey ("d")) {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("a")) {
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// if we've fallen off the edge
		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
