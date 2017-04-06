using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameConfiguration : MonoBehaviour {
	public InputField firstTeamName;
	public InputField secondTeamName;
	public InputField maxScore;
	public GameController gameController;

	public void Save() {
		Debug.Log ("DUPA");
		Debug.Log (maxScore.text);
		gameController.BuildGame (
			CreateTeam(firstTeamName.text),
			CreateTeam(secondTeamName.text),
			Int32.Parse(maxScore.text)
		);
	}

	private Team CreateTeam(string name) {
		return new Team (name);
	}
}
