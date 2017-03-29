using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0, -50000, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
