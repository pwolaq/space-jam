using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionReset : MonoBehaviour {
    private Vector3 position;
    private Quaternion rotation;
    private Rigidbody rb;

    void Start () {
        position = transform.position;
        rotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
	}

    public void Reset()
    {
        transform.position = position;
        transform.rotation = rotation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
