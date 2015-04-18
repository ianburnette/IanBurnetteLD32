using UnityEngine;
using System.Collections;

public class throwQueenOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Interacted () {
		transform.GetChild (0).GetComponent<Animator> ().SetTrigger ("fall");
		GetComponent<CameraFacingBillboard> ().enabled = false;
	}
}
