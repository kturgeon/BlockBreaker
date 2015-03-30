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
	
	
	
	
}
