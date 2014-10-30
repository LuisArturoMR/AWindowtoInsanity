using UnityEngine;
using System.Collections;

public class lamp : MonoBehaviour {

	public GameObject lampp;
	//public GameObject lampp2;
	public float duration = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	

	
	}

	void OnTriggerEnter(Collider c){

		if(c.gameObject.tag == "Player"){
			//float phi = Time.time / duration * 2 * Mathf.PI;
			//float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
			GetComponent<Light>().intensity = 10;
		}

	}

	void OnTriggerExit(Collider c){
		if(c.gameObject.tag == "Player"){
			GetComponent<Light>().intensity = 0;
		}
	}
}
