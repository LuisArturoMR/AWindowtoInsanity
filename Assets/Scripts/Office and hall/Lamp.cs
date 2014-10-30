using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour {

	public AudioClip[] audioClip;
	public GameObject lamp;
	public float duration = 10.0f;

	void playSound(int clip){
		GetComponent<AudioSource>().clip = audioClip [clip];
		GetComponent<AudioSource>().Play();
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider c){
		
		if(c.gameObject.tag == "Player"){
			//float phi = Time.time / duration * 2 * Mathf.PI;
			//float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
			GetComponent<Light>().intensity = 10;

		}
		if(c.gameObject.tag == "Boy"){
			float phi = Time.time / duration * 2 * Mathf.PI;
			float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
			GetComponent<Light>().intensity = amplitude+10;
			//playSound(0);
		}
		
	}

	void OnTriggerEnter(Collider c){

		playSound(0);
	}
	
	void OnTriggerExit(Collider c){
		if(c.gameObject.tag == "Player"){
			GetComponent<Light>().intensity = 0;
			playSound(1);
		}
		if(c.gameObject.tag == "Boy"){
			GetComponent<Light>().intensity = 0;
			playSound(1);
		}
	}


}
