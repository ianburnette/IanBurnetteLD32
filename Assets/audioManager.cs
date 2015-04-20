using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class audioManager : MonoBehaviour {

	public Slider slide;
	public float masterAudio;

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (gameObject);
	}

	void OnLevelWasLoaded(int level){
		if (Application.loadedLevel == 1) {
			//slide = GameObject.Find("Slider").GetComponent<Slider>();
			if (slide != null){
				slide.value = masterAudio;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ((Application.loadedLevel == 0 || Application.loadedLevel == 1) && slide != null) {
			masterAudio = slide.value;
		}
		AudioListener.volume = masterAudio;
	}
}
