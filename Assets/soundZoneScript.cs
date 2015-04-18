using UnityEngine;
using System.Collections;

public class soundZoneScript : MonoBehaviour {

	public AudioClip clipToPlay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			AudioSource narratorSource = col.transform.GetChild(0).GetComponent<AudioSource>();
			narratorSource.clip = clipToPlay;
			narratorSource.Play();
			Destroy(gameObject);
		}
	}
}
