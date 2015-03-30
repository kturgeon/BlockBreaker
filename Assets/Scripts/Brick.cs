using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private int maxHits;

	public int timesHit;
	
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnCollisionEnter2D (Collision2D collision) {
		timesHit++;
		//SimulateWin();
		
		Destroy(gameObject);
		
	}	
	
	// TODO Remove this method once we cna actually win!
	void SimulateWin() {
		levelManager.LoadNextLevel();	
	}
	
}
