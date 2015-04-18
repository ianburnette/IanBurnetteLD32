using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class fallScript : MonoBehaviour {

	public Transform player;
	public AudioClip secondaryFallClip;
	public AudioClip primaryFallClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			col.transform.GetComponent<FirstPersonController>().Falling();
			if (transform.name == "UpperParapetSoundZone"){
				if (player.GetComponent<endingScenario>().listenForEnd){
					col.GetComponent<endingScenario>().FellOff(secondaryFallClip);
				}else{
					col.GetComponent<endingScenario>().FellOff(primaryFallClip);
				}

			}
			else{
				col.GetComponent<endingScenario>().FellOff(primaryFallClip);
			}
		}
	}
}
