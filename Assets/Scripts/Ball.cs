using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	bool hasStarted = false;
	
	private Paddle paddle;

	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (!hasStarted) {
			//lock the ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			//wait for mouse press to launch ball and start game
			if (Input.GetMouseButtonDown(0)) {
				hasStarted = true;	
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}
		
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		// Ball does not trigger sound when brick is destroyed
		Vector2 tweak = new Vector2 (Random.Range (0f, 0.2f), Random.Range(0f, 0.2f));
		if (hasStarted) {
			audio.Play ();
			rigidbody2D.velocity += tweak;
		}

	}
	
	
}
