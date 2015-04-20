using UnityEngine;
using System.Collections;

public class endMenu : MonoBehaviour {

	public Transform checkpointMaster;
	public Transform main, credits;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TryAgain(int checkpoint){
		checkpointMaster.GetComponent<CheckpointScript> ().ChooseCheckpoint (checkpoint);
		Application.LoadLevel (1);

	}

	public void Credits(){
		main.gameObject.SetActive (false);
		credits.gameObject.SetActive (true);
	}

	public void MainMenu(){
		Application.LoadLevel (0);
	}
}
