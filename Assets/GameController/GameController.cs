using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GUIText scoreText;
	public GameObject goalGateA;
	public GameObject goalGateB;

	private GameSettings gameSettings;

	void Start () {
		DisplayScore ();
	}

	public void BuildGame(Team teamA, Team teamB, int maxScores) {
		Debug.Log ("ASDASD");
		teamA.AddGoalGate (goalGateA);
		teamB.AddGoalGate (goalGateB);
		this.gameSettings = new GameSettings (teamA, teamB, maxScores);
		SceneManager.LoadScene (0);
	}

	public void UpdateScore(Team team) {
		gameSettings.GetTeam(team.GetHashCode()).AddScore ();
		DisplayScore ();
	}

	public void DisplayScore() {
		scoreText.text = "0 : 0";
	}
}
