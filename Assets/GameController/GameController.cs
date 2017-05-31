using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
    private Controller ui;
	public static GameController instance;
    private Team[] teams;
    private bool shouldUpdateScore = true;

    public string nameA = "Team A";
    public string nameB = "Team B";
    public int maxScore = 10;

	void Awake() {
		if (!instance) {
			instance = this;
		}

		DontDestroyOnLoad(this) ;
	}

    public void SetUI(Controller uiCtrl)
    {
        ui = uiCtrl;
        UpdateScore();
    }

    public void UpdateSettings(string nameA, string nameB, int maxScore)
    {
        this.nameA = nameA;
        this.nameB = nameB;
        this.maxScore = maxScore;
    }

	public void StartGame() {
        Team teamA = new Team(nameA, Enums.Team.A);
        Team teamB = new Team(nameB, Enums.Team.B);

        teams = new Team[]{ teamA, teamB };

		SceneManager.LoadScene(1);
	}

	public void AddScore(Enums.Team team) {
        if (shouldUpdateScore)
        {
            Team scored = teams[(int)team];
            shouldUpdateScore = false;
            scored.AddScore();
            UpdateScore();

            if (scored.GetScore() >= maxScore)
            {
                ui.DisplayInfo(scored.GetName() + " wins!");
                StartCoroutine(WaitAfterFinish());
            }
            else
            {
                ui.DisplayInfo(scored.GetName() + " scores!");
                StartCoroutine(WaitAfterGoal());
            }

        }
	}

    IEnumerator WaitAfterGoal()
    {
        yield return new WaitForSeconds(5);
        Reset();
        ui.HideInfo();
    }

    IEnumerator WaitAfterFinish()
    {
        yield return new WaitForSeconds(10);
        ui.HideInfo();
        SceneManager.LoadScene(0);
    }

    private void Reset()
    {
        shouldUpdateScore = true;

        foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
        {
            PositionReset car = player.GetComponent<PositionReset>();
            car.Reset();
        }

        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        PositionReset ballReset = ball.GetComponent<PositionReset>();
        ballReset.Reset();
    }

    public void UpdateScore() {
        int scoreA = teams[(int) Enums.Team.A].GetScore();
        int scoreB = teams[(int) Enums.Team.B].GetScore();
        ui.UpdateScore(scoreA, scoreB);
	}
}
