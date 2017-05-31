using UnityEngine;

public class ScoreCounter : MonoBehaviour {
    public Enums.Team oppositeTeam;

	private GameController gameController;

    void Start()
    {
        gameController = GameController.instance;
    }

	void OnTriggerStay(Collider collisionInfo)
    {
		if (collisionInfo.CompareTag("Ball"))
        {
			gameController.AddScore(oppositeTeam);
		}
	}
}
