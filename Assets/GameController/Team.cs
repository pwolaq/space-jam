using System;
using UnityEngine;

public class Team {
	private GameObject goalGate;
	private string name;
	private int scores;

	public Team (string name) {
		this.name = name;
		this.scores = 0;
	}

	public void AddScore () {
		scores += 1;
	}

	public void AddGoalGate(GameObject goalGate) {
		goalGate.tag = this.GetHashCode ().ToString ();
		this.goalGate = goalGate;
	}
}

