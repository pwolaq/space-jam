using UnityEngine;

public class ScoreCounter : MonoBehaviour {
    public Enums.Team oppositeTeam;

	private GameController gameController;
	private bool shouldUpdateScore = true;

    void Start()
    {
        gameController = GameController.instance;
    }

	void OnTriggerStay(Collider collisionInfo)
    {
		if (collisionInfo.CompareTag("Ball") && shouldUpdateScore)
        {
			gameController.AddScore(oppositeTeam);
			shouldUpdateScore = false;
		}
	}
}
