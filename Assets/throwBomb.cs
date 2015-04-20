using UnityEngine;
using System.Collections;

public class throwBomb : MonoBehaviour {

	public float throwSpeed, torqueSpeed;
	public Vector3 placeLocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Interacted () {
		transform.GetChild (1).gameObject.SetActive (true);// = true;
		transform.parent = null;
		Rigidbody rb = transform.GetComponent<Rigidbody> ();
		rb.isKinematic = false;
		rb.AddForce (Vector3.forward * throwSpeed);
		rb.AddTorque (Vector3.up * torqueSpeed);

		//GetComponent<CameraFacingBillboard> ().enabled = false;
	}

	public void Placed () {
		transform.GetChild (1).gameObject.SetActive (true);// = true;
		transform.parent = null;
		transform.position = placeLocation;
		Rigidbody rb = transform.GetComponent<Rigidbody> ();
		rb.isKinematic = false;
		transform.GetComponent<SphereCollider> ().enabled = true;
		//rb.AddForce (Vector3.forward * throwSpeed);
		//rb.AddTorque (Vector3.up * torqueSpeed);
		
		//GetComponent<CameraFacingBillboard> ().enabled = false;
	}
}
