using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class stopRunning : MonoBehaviour {

	public FirstPersonController controller;

	
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			SpeedDown();
		}
	}
	
	public void SpeedDown(){
		controller.ChangePace (6.5f);
	}
}
