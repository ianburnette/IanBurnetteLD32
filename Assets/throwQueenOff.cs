using UnityEngine;
using System.Collections;

public class throwQueenOff : MonoBehaviour {

	public Transform guardsToCall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Interacted () {
		transform.GetChild (0).GetComponent<Animator> ().SetTrigger ("fall");
		guardsToCall.gameObject.SetActive (true);
		GetComponent<CameraFacingBillboard> ().enabled = false;
	}
}
