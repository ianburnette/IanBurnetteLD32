using UnityEngine;
using System.Collections;

public class queenFollow : MonoBehaviour {

	NavMeshAgent agent;
	public Transform target;
	public Animator anim;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		anim = transform.GetChild(0).GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target!=null) {
			agent.destination = target.position;
		}
		Animate ();
	}

	public void SetTarget(Transform newTarget, float stoppingDist){
		target = newTarget;
		agent.stoppingDistance = stoppingDist;
	}

	void Animate(){
		if (agent.velocity != Vector3.zero) {
			anim.SetBool ("walking", true);
		} else {
			anim.SetBool ("walking", false);
		}
	}
}
