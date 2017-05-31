using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
    private GameController gameController;
    public Text score;
    public Text nameA;
    public Text nameB;
    public Text info;
    public GameObject infoDialog;

	void Start () {
        GameController.instance.SetUI(this);
    }

    public void SetTeamA(string name)
    {
        nameA.text = name;
    }

    public void SetTeamB(string name)
    {
        nameB.text = name;
    }

    public void DisplayInfo(string text)
    {
        info.text = text;
        infoDialog.SetActive(true);
    }

    public void HideInfo()
    {
        infoDialog.SetActive(false);
    }

    public void UpdateScore(int scoreA, int scoreB)
    {
        score.text = scoreA + " : " + scoreB;
    }
}
