using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	private Light flashlightLightSource;
	private bool flashlightOn = false;
	public float lightDrain = 0.1f;
	private float batteryLife = 0.0f;
	public float maxBatteryLife = 2.0f;
	
	public AudioClip turnOn;
	public AudioClip turnOff;

	private bool isEquipped = false;

	void EquipFlashLight(){
		isEquipped = true;
	}

	void Start(){
		batteryLife = maxBatteryLife;
		flashlightLightSource = GetComponent<Light>();
		flashlightLightSource.enabled = false;
	}

	
	void toggleFlashlight(){
		if(flashlightOn)
		{
			flashlightLightSource.enabled = false;
			flashlightOn = false;
		}
		else
		{
			flashlightLightSource.enabled = true;
			flashlightOn = true;
		}
	}

	void toggleFlashlightSFX()
	{
		if(flashlightLightSource.enabled)
		{
			GetComponent<AudioSource>().clip = turnOn;
		}
		else
		{
			GetComponent<AudioSource>().clip = turnOff;
		}
		GetComponent<AudioSource>().Play();
		
	}

	// Update is called once per frame
	void Update () {

				//BATTERY LIFE BRIGHTNESS//////////
				/*if (flashlightOn && batteryLife >= 0)
						batteryLife -= Time.deltaTime * lightDrain;

				if (flashlightOn && batteryLife <= 0.4)
						flashlightLightSource.GetComponent<Light> ().intensity = 5;

				if (flashlightOn && batteryLife <= 0.3)
						flashlightLightSource.GetComponent<Light> ().intensity = 4;

				if (flashlightOn && batteryLife <= 0.2)
						flashlightLightSource.GetComponent<Light> ().intensity = 3;

				if (flashlightOn && batteryLife <= 0.1)
						flashlightLightSource.GetComponent<Light> ().intensity = 2;

				if (flashlightOn && batteryLife <= 0)
						flashlightLightSource.GetComponent<Light> ().intensity = 0;

				barDisplay = batteryLife;
		
				if (batteryLife <= 0) {
						batteryLife = 0;
						flashlightOn = false;
				}*/

				/*if (Input.GetButtonDown ("Flashlight") && flashlightOn == false) {
			GetComponent<Light> ().intensity = 3;
			flashlightOn = true;
		}
		else if (Input.GetButtonDown ("Flashlight") && flashlightOn) {
			GetComponent<Light> ().intensity = 0;
			flashlightOn = false;
		}*/
			if (isEquipped){
				if (Input.GetButtonDown ("Flashlight")) {
					toggleFlashlight ();
					toggleFlashlightSFX ();
				}
			}
				/*if (flashlightOn) {
					flashlightOn = false;
				} else if (!flashlightOn && batteryLife >= 0) {
					flashlightOn = true;
					}
				}*/
		}

		/*void OnGUI(){
				// draw the background:
				GUI.BeginGroup (new Rect (pos.x, pos.y, size.x, size.y));
				GUI.Box (Rect (0,0, size.x, size.y),progressBarEmpty);
				
				// draw the filled-in part:
				GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
				GUI.Box (Rect (0,0, size.x, size.y),progressBarFull);
				GUI.EndGroup ();
				
				GUI.EndGroup ();
				
		}*/

}
