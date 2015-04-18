using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class jumpOffBalcony : MonoBehaviour {

	public Transform playerTransform;
	public AudioClip endingClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			playerTransform.GetComponent<FirstPersonController> ().Falling ();
			playerTransform.GetComponent<endingScenario> ().ReachedEnd (endingClip);
		}
	}



}
