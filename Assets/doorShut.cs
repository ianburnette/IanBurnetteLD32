using UnityEngine;
using System.Collections;

public class doorShut : MonoBehaviour {

	bool closeAfter;
	public Transform door1, door2, door3, door4;
	public Vector3 door1Offset, door2Offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			Close();
		}
	}

	void Close(){
		door1.gameObject.SetActive (false);
		door2.gameObject.SetActive (false);
		door3.gameObject.SetActive (true);
		door4.gameObject.SetActive (true);
		GetComponent<AudioSource> ().Play ();
	}
}
