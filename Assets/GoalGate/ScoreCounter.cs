using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
	public GameController gameController;
    public Scores.Team team;

	private bool shouldUpdateScore = true;

	void OnTriggerStay(Collider collisionInfo)
    {
		if (collisionInfo.CompareTag("Ball") && shouldUpdateScore)
        {
			gameController.UpdateScore((int) team);
			shouldUpdateScore = false;
		}
	}
}
