using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class fallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			col.transform.GetComponent<FirstPersonController>().Falling();
		}
	}
}
