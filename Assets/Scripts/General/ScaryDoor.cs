using UnityEngine;
using System.Collections;

public class ScaryDoor : MonoBehaviour {
	private bool trigger = false;
	private bool played = false;
	private bool animated = false;
	public GameObject door;
	public AudioClip sound;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			trigger = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (trigger == true) {
			Animate();
			Sound ();
		}
	}

	//// sound /////
	void Sound() {
		if (!played) {
			played = true;
			door.GetComponent<AudioSource>().PlayOneShot(sound);
		}
	}

	void Animate(){
		if (!animated) {
			animated = true;
			door.GetComponent<Animation> () ["Open Door"].speed = 0.5f;
			door.GetComponent<Animation> ().Play ("Open Door");
		}
	}
	

}
