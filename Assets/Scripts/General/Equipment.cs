using UnityEngine;
using System.Collections;

public class Equipment : MonoBehaviour {
	public GameObject flashlight;

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player"){

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
