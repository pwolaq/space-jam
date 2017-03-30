using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GUIText scoreText;

	private Scores scores;

	// Use this for initialization
	void Start () {
		scores = new Scores ("asd", "qwe");
		DisplayScore ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScore(string team) {
		Debug.Log ("asd");
		scores.increment (team);
		DisplayScore ();
	}

	public void DisplayScore() {
		scoreText.text = this.scores.ToString ();
	}
}
