using UnityEngine;
using System;
using UnityEngine.UI;

public class GameConfiguration : MonoBehaviour {
	public InputField teamA;
	public InputField teamB;
	public InputField score;
	private GameController gameController;

    public void Awake()
    {
        gameController = GameController.instance;
    }

    public void SetControls()
    {
        teamA.text = gameController.nameA;
        teamB.text = gameController.nameB;
        score.text = gameController.maxScore.ToString();
    }

	public void Save() {
		gameController.UpdateSettings(teamA.text, teamB.text, Int32.Parse(score.text));
	}
}
