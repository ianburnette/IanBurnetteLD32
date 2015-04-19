using UnityEngine;
using System.Collections;

public class controlTest : MonoBehaviour {

	int buttonsToGo = 5;
	public Transform[] buttons;
	public float torqueAmt;
	public bool w, a, s, d, m;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Vertical") > 0 && !w) {
			buttons[0].GetComponent<Rigidbody>().isKinematic = false;
			buttons[0].GetComponent<Rigidbody>().AddTorque(Vector3.forward * torqueAmt);
			//Destroy(buttons[0].gameObject);
			w = true;
			buttonsToGo--;
		}
		if (Input.GetAxis ("Vertical") < 0 && !s) {
			buttons[1].GetComponent<Rigidbody>().isKinematic = false;
			buttons[1].GetComponent<Rigidbody>().AddTorque(Vector3.forward * torqueAmt);
			s = true;
			buttonsToGo--;
		}
		if (Input.GetAxis ("Horizontal") < 0&& !a) {
			buttons[2].GetComponent<Rigidbody>().isKinematic = false;
			buttons[2].GetComponent<Rigidbody>().AddTorque(Vector3.forward * torqueAmt);
			a = true;
			buttonsToGo--;
		}
		if (Input.GetAxis ("Horizontal") > 0&& !d) {
			buttons[3].GetComponent<Rigidbody>().isKinematic = false;
			buttons[3].GetComponent<Rigidbody>().AddTorque(Vector3.forward * torqueAmt);
			d = true;
			buttonsToGo--;
		}
		if (Input.GetButtonDown ("Fire1")&& !m) {
			buttons[4].GetComponent<Rigidbody>().isKinematic = false;
			buttons[4].GetComponent<Rigidbody>().AddTorque(Vector3.forward * torqueAmt);
			m = true;
			buttonsToGo--;
		}
		if (buttonsToGo <= 0) {
			Application.LoadLevel(1);
		}
	}
}
