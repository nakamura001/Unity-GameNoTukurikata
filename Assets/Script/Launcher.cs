using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
	public GameObject ballPrefab;
	
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			Instantiate(this.ballPrefab);
		}
	}
}
