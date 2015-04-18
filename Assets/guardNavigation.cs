using UnityEngine;
using System.Collections;

public class guardNavigation : MonoBehaviour {

	NavMeshAgent nav;
	public Transform target;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			nav.destination = target.position;
		}
	}

	public void SetDestination(Transform dest){	
		target = dest;
	}
}
