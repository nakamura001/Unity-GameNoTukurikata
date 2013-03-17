using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	void Start () {
		this.rigidbody.velocity = new Vector3(-8.0f, 8.0f, 0.0f);
	}
}