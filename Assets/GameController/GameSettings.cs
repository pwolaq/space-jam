using System;
using Enums;
using System.Collections.Generic;

public class GameSettings {
	private Dictionary<string, Team> teams = new Dictionary<string, Team>();
	private int maxScore;

	public GameSettings (Team teamA, Team teamB, int maxScore) {
		this.teams.Add (Enums.TeamTags.A.ToString(), teamA);
		this.teams.Add (Enums.TeamTags.B.ToString(), teamB);
		this.maxScore = maxScore;
	}

	public Team GetTeam(string team) {
		return teams [team];
	}
}
	