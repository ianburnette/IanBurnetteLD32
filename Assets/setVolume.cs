using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class setVolume : MonoBehaviour {

	public GameObject gm;
	public Slider slidey;

	// Use this for initialization
	void OnEnable () {
		gm = GameObject.Find ("_gm");
		slidey.value = gm.GetComponent<audioManager>().masterAudio;
		gm.GetComponent<audioManager> ().slide = slidey;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
