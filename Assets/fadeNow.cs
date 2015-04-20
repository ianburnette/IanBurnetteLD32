using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeNow : MonoBehaviour {

	public Image black, logo;
	public float timeAmt;
	public float fadeAmt = .01f;
	public bool fade;

	// Use this for initialization
	void Start () {
		Invoke ("FadeSelf", timeAmt);
		Invoke ("DestroySelf", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		if (fade) {
			black.color = new Color (0,0,0,black.color.a - fadeAmt);
			logo.color = new Color (255,255,255,logo.color.a - fadeAmt);
		}if (black.color.a == 0) {
			Destroy (gameObject);
		}
	}

	void FadeSelf(){
		fade = true;
	}

	void DestroySelf(){
		Destroy (gameObject);
	}
}
