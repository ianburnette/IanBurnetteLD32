using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class interact : MonoBehaviour {

	bool interactible;
	public AudioClip endingClip;
	public Transform UIParent;
	public string interactString;
	public Transform objectToChange;
	public Transform playerTransform;
	public Transform guardsToCall;

	// Use this for initialization
	void Start () {
		GameObject temp = GameObject.FindWithTag("Player");
		playerTransform = temp.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && interactible) {
			SetUIActive(false);
			if (transform.name != "placeBomb") {
				objectToChange.BroadcastMessage("Interacted");
			}else{
				objectToChange.BroadcastMessage("Placed");
			}

			SendMessageToPlayer();
			Destroy(gameObject);
		}
	}

	void SendMessageToPlayer(){
		if (transform.name != "placeBomb") { //queen and throw bomb
			if (transform.name == "throwQueen"){
				PlayerPrefs.SetInt("sicko", 1);
			}else if (transform.name == "throwBomb"){
				PlayerPrefs.SetInt("rubbish", 1);
			}
			playerTransform.GetComponent<FirstPersonController> ().Falling ();
			playerTransform.GetComponent<FirstPersonController> ().StopFootSteps ();
			playerTransform.GetComponent<endingScenario> ().ReachedEnd (endingClip);
		} else {
			guardsToCall.gameObject.SetActive (true); //place bomb 
			playerTransform.GetComponent<FirstPersonController> ().StopFootSteps ();
			playerTransform.GetComponent<endingScenario> ().ReachedEnd (endingClip);
			playerTransform.GetComponent<endingScenario> ().PlacedBomb();
		}
	}

	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			interactible = true;
			SetUIActive(true);
		}
	}

	void OnTriggerExit (Collider col) {
		if (col.transform.tag == "Player") {
			interactible = false;
			SetUIActive(false);
		}
	}

	void SetUIActive(bool switchDirection){
		UIParent.GetChild (2).GetComponent<Text>().text = interactString;
		UIParent.gameObject.SetActive (switchDirection);
	}
}
