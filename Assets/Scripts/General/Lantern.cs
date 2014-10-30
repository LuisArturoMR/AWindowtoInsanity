using UnityEngine;
using System.Collections;

public class Lantern : MonoBehaviour {
	public GameObject lantern;
	private bool used = false;
	public GameObject audioController;
	public GameObject flashlight;

	void OnTriggerStay(){
		if(Input.GetButtonDown ("Action")){
			audioController.SendMessage("Equipment");
			flashlight.SendMessage("EquipFlashLight");
			Destroy(lantern);
		}
	}
}
