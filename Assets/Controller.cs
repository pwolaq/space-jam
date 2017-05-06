using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
    private GameController gameController;
    public Text score;

	void Start () {
        gameController = GameController.instance;
        gameController.SetScoreUI(score);
    }
}
