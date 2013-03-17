using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	protected float jump_speed = 5.0f;
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			this.rigidbody.velocity = Vector3.up * this.jump_speed;
		}
	}
}
