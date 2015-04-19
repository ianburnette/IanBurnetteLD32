using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public Transform main, soundTest, controls;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 0) {

		}
	}

	public void ShowMain(){
		main.gameObject.SetActive (true);
		soundTest.gameObject.SetActive (false);
		controls.gameObject.SetActive (false);
	}

	public void ShowSoundTest(){
		main.gameObject.SetActive (false);
		soundTest.gameObject.SetActive (true);
		controls.gameObject.SetActive (false);
	}

	public void ShowControls(){
		main.gameObject.SetActive (false);
		soundTest.gameObject.SetActive (false);
		controls.gameObject.SetActive (true);
	}

	public void Quit(){
		Application.Quit ();
	}
}
