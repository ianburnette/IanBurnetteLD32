using UnityEngine;
using System.Collections;

public class explosionScript : MonoBehaviour {

	public Light myLight;
	public float lightDecrement;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
		Invoke ("DestroySelf", 5f);
	}
	
	// Update is called once per frame
	void Update () {
		myLight.intensity = myLight.intensity - lightDecrement;
	}

	void DestroySelf (){
		Destroy (gameObject);
	}
}
