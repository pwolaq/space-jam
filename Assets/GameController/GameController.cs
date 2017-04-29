using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GUIText scoreText;
	private GameSettings gameSettings;
	public static GameController instance ;

	void Start () {
		DisplayScore ();
	}

	void Awake() {
		if (!instance) {
			instance = this;
		}

		DontDestroyOnLoad(this) ;
	}

	public void BuildGame(Team teamA, Team teamB, int maxScores) {
//		teamA.AddGoalGate (goalGateA);
//		teamB.AddGoalGate (goalGateB);
		this.gameSettings = new GameSettings (teamA, teamB, maxScores);
		SceneManager.LoadScene (0);
	}

	public void UpdateScore(string teamTag) {
		gameSettings.GetTeam(teamTag).AddScore ();
		DisplayScore ();
	}

	public void DisplayScore() {
		scoreText.text = "0 : 0";
	}
}
