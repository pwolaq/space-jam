using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour {
	public GameController gameController;
	private bool shouldUpdateScore = true;

	private string teamName = "asd";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider collisionInfo){
		if (shouldUpdateScore) {
			gameController.UpdateScore (this.teamName);
			this.shouldUpdateScore = false;
		}
	}

	private void CheckScoreCondition () {
		
	}
}
