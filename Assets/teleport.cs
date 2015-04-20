using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class teleport : MonoBehaviour {

	public Transform spiralStaircase, player;
	public Vector3 offset;
	public FirstPersonController controller;

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
		controller.ChangePace (10f);
		Invoke ("SpeedUp", 10f);
	}

	public void SpeedUp(){
		controller.ChangePace (10f);
	}
}
