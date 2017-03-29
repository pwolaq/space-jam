using System;
using System.Collections.Generic;

public class Scores {
	private Dictionary<string, int> scores = new Dictionary<string, int>();
	private string teamA;
	private string teamB;

	public Scores (string teamA = "teamA", string teamB = "teamB") {
		this.teamA = teamA;
		this.teamB = teamB;

		this.scores.Add (teamA, 0);
		this.scores.Add (teamB, 0);
	}

	public void increment (string team) {
		scores [team] += 1;
	}

	public string ToString () {
		return scores[this.teamA] + " : " + scores[this.teamB];
	}
}

