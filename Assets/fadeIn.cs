using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class fadeIn : MonoBehaviour {

	public FirstPersonController controller;
	public Image fade;
	public float increment, waitTime;
	public bool begin, unfaded;

	// Use this for initialization
	void Start () {
		fade = GetComponent<Image> ();
		fade.color = new Color (0, 0, 0, 1);
		Invoke ("Begin", waitTime/4);
		Invoke ("Controls", waitTime);
		controller.StopMoving ();// = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (fade.color.a != 0 && begin && !unfaded) { 
			fade.color = new Color (0, 0, 0, fade.color.a - (increment * Time.deltaTime));
		} else if (begin) {
			unfaded = true;
		}
	}

	void Controls(){
		controller.StartMoving ();//controller.enabled = true;
		fade.color = new Color (0, 0, 0, 0);
		unfaded = true;
	}

	void Begin (){
		begin = true;
	
	}
}
