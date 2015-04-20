using UnityEngine;
using System.Collections;

public class CheckpointScript : MonoBehaviour {

	public int currentCheckpoint;
	public Transform checkpointSetter;

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (gameObject);
	}

	public void ChooseCheckpoint(int which){
		currentCheckpoint = which;
	}

	// Update is called once per frame
	void OnLevelWasLoaded(int level) {
		if (level == 1) {
			checkpointSetter = GameObject.FindGameObjectWithTag ("CheckpointSetter").transform;
			if (currentCheckpoint != 3) {
				checkpointSetter.GetComponent<checkpointSetter> ().Checkpoint (currentCheckpoint);
			}
		}
	}
}
