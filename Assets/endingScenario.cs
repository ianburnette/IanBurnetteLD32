using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class endingScenario : MonoBehaviour {

	public AudioSource thisSource;
	public bool listenForEnd;
	public Transform bomb;
	public Transform explosion;
	public Image fadeScreen;
	public bool fadeNow;
	public float increment;
	public Transform guards;

	// Use this for initialization
	void Update () {
		if (listenForEnd && !thisSource.isPlaying) {
			print ("finished");
			Application.LoadLevel(Application.loadedLevel+1);
		}
		if (fadeNow) {
			print (thisSource.clip.length);
			float timeOfClip = thisSource.clip.length;
			increment = 1f/timeOfClip;
			InvokeRepeating("FadeIncrement", 0, 1f);
			fadeScreen.color = new Color(0,0,0,fadeScreen.color.a + (increment * Time.deltaTime));
		
			//fadeScreen.color = new Color(0,0,0,1f);
		}
	}

	void FadeIncrement(){
		//fadeScreen.color = new Color(0,0,0,fadeScreen.color.a + increment);
	}

	// Update is called once per frame
	public void ReachedEnd (AudioClip clipToPlay) {
		thisSource.clip = clipToPlay;
		listenForEnd = true;
		thisSource.volume = 1;
		thisSource.Play();
		fadeNow = true;
	}

	public void PlacedBomb(){
		Invoke ("ExplodeBomb", 16f);

	}

	void ExplodeBomb(){
		transform.GetComponent<FirstPersonController>().Falling();
		bomb.gameObject.SetActive (false);
		explosion.gameObject.SetActive (true);
		foreach (Transform guard in guards) {
			guard.GetComponent<guardNavigation>().target=null;
			guard.GetComponent<NavMeshAgent>().enabled = false;// = 0f;
			//print (guard.name);
		}
	}

	void ResetFade(){
		fadeScreen.color = new Color(0,0,0,0f);
	}

	public void FellOff(AudioClip clipToPlay){
		if (listenForEnd) {
			//fadeNow = true;
			ResetFade();
			transform.GetChild(0).GetComponent<AudioSource>().Stop();
			CancelInvoke ("ExplodeBomb");
			listenForEnd = false;
			thisSource.Stop ();
			thisSource.clip = clipToPlay;
			thisSource.Play ();
			listenForEnd = true;
		} else {
			fadeNow = true;
			transform.GetChild(0).GetComponent<AudioSource>().Stop();
			listenForEnd = false;
			thisSource.volume = 1;
			thisSource.Stop ();
			thisSource.clip = clipToPlay;
			thisSource.Play ();
			listenForEnd = true;
		}

	}
}
