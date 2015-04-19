using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour {

	public bool paused = false;

	public GameObject pauseCanvas, main, sureQuit, sureRestart, sound;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			if (paused){
				Unpause();
			}else{
				Pause ();
			}
		}
	}

	void Pause(){
		Time.timeScale = 0f;
		pauseCanvas.SetActive (true);
	}

	public void Unpause(){
		ResetCanvas ();
		pauseCanvas.SetActive (false);
		ResetScale ();
	}

	void ResetScale(){
		Time.timeScale = 1f;
	}

	public void ResetCanvas(){
		main.SetActive (true);
		sound.SetActive (false);
		sureQuit.SetActive (false);
		sureRestart.SetActive (false);
	}

	public void Quit1 (){
		main.SetActive (false);
		sound.SetActive (false);
		sureQuit.SetActive (true);
		sureRestart.SetActive (false);
	}

	public void Quit2 () {
		ResetScale ();
		Application.LoadLevel (0);
	}

	public void Restart1(){
		main.SetActive (false);
		sound.SetActive (false);
		sureQuit.SetActive (false);
		sureRestart.SetActive (true);
	}

	public void Restart2(){
		ResetScale ();
		Application.LoadLevel (1);
	}

	public void Sound(){
		main.SetActive (false);
		sound.SetActive (true);
		sureQuit.SetActive (false);
		sureRestart.SetActive (false);
	}
}
