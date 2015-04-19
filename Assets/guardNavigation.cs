using UnityEngine;
using System.Collections;

public class guardNavigation : MonoBehaviour {

	NavMeshAgent nav;
	public Transform target;
	public Animator anim;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		anim = transform.GetChild (0).GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			nav.destination = target.position;
			Animate();
		}
	}

	public void SetDestination(Transform dest){	
		target = dest;
	}

	void Animate(){
		if (nav.velocity != Vector3.zero) {
			anim.SetBool ("moving", true);
		} else {
			anim.SetBool ("moving", false);
		}
	}
}
