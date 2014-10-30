using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public GameObject door;
	private bool open = false;

	public AudioClip doorOpen;
	public AudioClip doorClose;

	void OnTriggerStay(){
		if (Input.GetButtonDown ("Action") && open == false){
			door.GetComponent<Animation> ().Play ("Open Door");
			GetComponent<AudioSource> ().clip = doorOpen;
			GetComponent<AudioSource> ().Play ();
			open = true;
		} else if (Input.GetButtonDown ("Action") && open) {
			door.GetComponent<Animation> ().Play ("Close Door");
			GetComponent<AudioSource> ().clip = doorClose;
			GetComponent<AudioSource> ().Play ();
			open = false;
			}
	}

	// Update is called once per frame
	void Update () {

	}
}
