using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
    private GameController gameController;
    public Text score;
    public Text nameA;
    public Text nameB;

	void Start () {
        gameController = GameController.instance;
        gameController.SetScoreUI(score);

        nameA.text = gameController.nameA;
        nameB.text = gameController.nameB;
    }
}
