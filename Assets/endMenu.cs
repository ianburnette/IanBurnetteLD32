using UnityEngine;
using System.Collections;

public class endMenu : MonoBehaviour {

	/*
	 * PlayerPrefs
	 * 
	 * slip
	 * sicko
	 * rubbish
	 * meh
	 * stupid
	 * symbolic 
	 * 
	 * */

	public GameObject whoa;
	public int count;
	public GameObject[] achievements, locks;
	public Transform checkpointMaster;
	public Transform main, credits;

	// Use this for initialization
	void Start () {
		foreach (GameObject ach in achievements) {
			ach.SetActive(false);
		}
		CheckAcievements ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Q)) {
			print ("slip = " + PlayerPrefs.GetInt("slip"));
			print ("sicko = " + PlayerPrefs.GetInt("sicko"));
			print ("rubbish = " + PlayerPrefs.GetInt("rubbish"));
			print ("meh = " + PlayerPrefs.GetInt("meh"));
			print ("stupid = " + PlayerPrefs.GetInt("stupid"));
			print ("symbolic = " + PlayerPrefs.GetInt("symbolic"));
		}
	}

	void CheckAcievements (){
		if (PlayerPrefs.GetInt ("meh") != 0) {
			achievements[0].SetActive(true);
			locks[0].SetActive(false);
			count++;
		}
		if (PlayerPrefs.GetInt ("slip") != 0) {
			achievements[1].SetActive(true);
			locks[1].SetActive(false);
			count++;
		}
		if (PlayerPrefs.GetInt ("stupid") != 0) {
			achievements[2].SetActive(true);
			locks[2].SetActive(false);
			count++;
		}
		if (PlayerPrefs.GetInt ("sicko") != 0) {
			achievements[3].SetActive(true);
			locks[3].SetActive(false);
			count++;
		}
		if (PlayerPrefs.GetInt ("rubbish") != 0) {
			achievements[4].SetActive(true);
			locks[4].SetActive(false);
			count++;
		}
		if (PlayerPrefs.GetInt ("symbolic") != 0) {
			achievements[5].SetActive(true);
			locks[5].SetActive(false);
			count++;
		}
		if (count == 6) {
			whoa.SetActive (true);
		}
	}

	public void TryAgain(int checkpoint){
		checkpointMaster.GetComponent<CheckpointScript> ().ChooseCheckpoint (checkpoint);
		Application.LoadLevel (1);

	}

	public void Credits(){
		main.gameObject.SetActive (false);
		credits.gameObject.SetActive (true);
	}

	public void BackToMain(){
		main.gameObject.SetActive (true);
		credits.gameObject.SetActive (false);
	}

	public void MainMenu(){
		Application.LoadLevel (0);
	}
}
