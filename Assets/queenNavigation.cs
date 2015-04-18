using UnityEngine;
using System.Collections;

public class queenNavigation : MonoBehaviour {

	public Transform queen;
	public Transform destinationForQueen;
	public float queenStoppingDist;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.transform.tag == "Player") {
			queen.GetComponent<queenFollow>().SetTarget(destinationForQueen, queenStoppingDist);
			//queen.GetComponent<queenFollow>().SetTarget(destinationForQueen);
		}
	}
}
