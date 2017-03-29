using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GUIText scoreText;

	private Scores scores;

	// Use this for initialization
	void Start () {
		scores = new Scores ("asd", "qwe");
		displayScore ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateScore(string team) {
		scores.increment (team);
		displayScore ();
	}

	void displayScore() {
		scoreText.text = this.scores.ToString ();
	}
}
