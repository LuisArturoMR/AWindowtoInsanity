#pragma strict

private var sanityScript : InsanityManager;
var sanity : AudioClip;
var scarePerc : float = 20.0;
var used : boolean = false;
var audioController : GameObject;

function Start () {
	sanityScript = GameObject.Find("First Person Controller").GetComponent(InsanityManager);
}

function OnTriggerStay(){
	if(Input.GetButtonDown ("Action")){
		sanityScript.currentSanity += scarePerc;
		audioController.SendMessage("Cure");
		Destroy(gameObject);
	}
}
