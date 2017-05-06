public class Team {
    public Enums.Team team;
	private string name;
	private int score;

	public Team (string name, Enums.Team team) {
		this.name = name;
		this.score = 0;
        this.team = team;
	}

	public void AddScore () {
		score += 1;
	}

    public int GetScore()
    {
        return score;
    }
}

