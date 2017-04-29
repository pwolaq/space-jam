using UnityEngine;

public class ScoreCounter : MonoBehaviour {
	public GameController gameController = GameController.instance;

	private bool shouldUpdateScore = true;

	void OnTriggerStay(Collider collisionInfo)
    {
		if (collisionInfo.CompareTag("Ball") && shouldUpdateScore)
        {
			Debug.Log (gameObject.tag);
			gameController.UpdateScore(gameObject.tag);
			shouldUpdateScore = false;
		}
	}
}
