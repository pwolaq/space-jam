using System;
using System.Collections.Generic;

public class GameSettings {
	private Dictionary<int, Team> teams = new Dictionary<int, Team>();
	private int maxScore;

	public GameSettings (Team teamA, Team teamB, int maxScore) {
		this.teams.Add (teamA.GetHashCode(), teamA);
		this.teams.Add (teamB.GetHashCode(), teamB);
		this.maxScore = maxScore;
	}

	public Team GetTeam(int team) {
		return teams [team];
	}
}

