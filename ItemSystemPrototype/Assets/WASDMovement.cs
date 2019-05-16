using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour {

	private float force = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.up * force);
		} else if (Input.GetKey (KeyCode.S)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.down * force);
		} else if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.left * force);
		} else if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.right * force);
		}
	}
}
