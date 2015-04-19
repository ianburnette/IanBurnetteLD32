using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	public Transform spiralStaircase, player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			Teleport();
		}
	}

	// Update is called once per frame
	public void Teleport () {
		//spiralStaircase.position += offset;
		player.transform.position += offset;
	}
}
