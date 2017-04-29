using Enums;

public class Scores
{
    private string[] names;
    private int[] scores;

	public Scores (string teamA = "teamA", string teamB = "teamB")
    {
        names = new string[] { teamA, teamB };
        scores = new int[] { 0, 0 };
	}

	public void Increment(int team)
    {
        scores[team]++;
	}

    override public string ToString()
    {
		return scores[(int) Enums.TeamTags.A] + " : " + scores[(int) Enums.TeamTags.B];
	}
}

