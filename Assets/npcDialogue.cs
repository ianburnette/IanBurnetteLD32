using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class npcDialogue : MonoBehaviour {

	public bool characterInRange, inDialogue;

	public Transform dialogueParent;
	public Text characterNameReference, currentDialogueReference;

	public string characterName;
	public string[] dialogues1;
	public string[] dialogues2;
	public string[] dialogues3;
	public string[] dialogues4;

	// Use this for initialization
	void Start () {
		SetupReferences ();
	}

	void SetupReferences(){
		if (!dialogueParent)
			dialogueParent = Camera.main.transform.GetChild (1).GetChild (1); 
		characterNameReference = dialogueParent.GetChild (1).GetComponent<Text>();
		currentDialogueReference = dialogueParent.GetChild (2).GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && characterInRange && !inDialogue) {
			SendDialogue (0);
		} else if (Input.GetButtonDown ("Fire1") && characterInRange && inDialogue) {
			EndDialogue();
		}
	}

	void SendDialogue(int index){
		inDialogue = true;
		dialogueParent.gameObject.SetActive (true);
		characterNameReference.text = characterName;

	}

	void EndDialogue (){
		dialogueParent.gameObject.SetActive (false);
		inDialogue = false;
	}

	void OnTriggerEnter(Collider col){
		if (col.transform.tag == "Player") {
			characterInRange = true;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.transform.tag == "Player") {
			characterInRange = false;
		}
	}
}
