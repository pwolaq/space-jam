using UnityEngine;

public class GameController : MonoBehaviour
{
	public GUIText scoreText;

	private Scores scores = new Scores();

    void Start()
    {
		DisplayScore();
	}

	public void UpdateScore(int team)
    {
        scores.Increment(team);
        DisplayScore();
    }

	public void DisplayScore()
    {
		scoreText.text = this.scores.ToString();
	}
}
