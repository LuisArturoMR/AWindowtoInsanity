using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
	public AudioClip plusSanity;
	public AudioClip flashlight;
	
	/*Destroy Cube*/
	void Cure(){
		GetComponent<AudioSource>().PlayOneShot(plusSanity);
	}
	
	void Equipment(){
		GetComponent<AudioSource>().PlayOneShot(flashlight);
	}
}
