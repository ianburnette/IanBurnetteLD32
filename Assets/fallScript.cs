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
			if (transform.name == "UpperParapetSoundZone"){ //fall off upper part
				if (player.GetComponent<endingScenario>().listenForEnd){ //late
					PlayerPrefs.SetInt("stupid", 1);
					col.GetComponent<endingScenario>().FellOff(secondaryFallClip);
				}else{ //early
					PlayerPrefs.SetInt("slip", 1);
					col.GetComponent<endingScenario>().FellOff(primaryFallClip);
				}

			}
			else{ //balcony
				PlayerPrefs.SetInt ("symbolic", 1);
				col.GetComponent<endingScenario>().FellOff(primaryFallClip);
			}
		}
	}
}
