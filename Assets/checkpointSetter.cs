using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class checkpointSetter : MonoBehaviour {

	public Transform player, hallway, tower, throneRoom, fade;
	public FirstPersonController controller;

	// Use this for initialization
	void Start () {
			
	}

	public void Checkpoint(int check){
		if (check == 0) {
			player.position = hallway.position;
			player.rotation = hallway.rotation;
		} else if (check == 1) {
			player.position = tower.position;
			player.rotation = tower.rotation;
		} else if (check == 2) {
			player.position = throneRoom.position;
			player.rotation = throneRoom.rotation;
		}

			player.GetChild (0).GetComponent<AudioSource>().Stop();
			fade.GetComponent<Image>().color = new Color (0,0,0,0);
			controller.StartMoving();
		

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha0)) {
			Checkpoint (0);
		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Checkpoint (1);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Checkpoint (2);
		}
	}
}
