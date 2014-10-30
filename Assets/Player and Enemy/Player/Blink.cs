using UnityEngine;
using System.Collections;

public class Blink : MonoBehaviour {
	public GameObject topLid;
	public GameObject botLid;
	public float timer = 5f;
	bool blink = false; 
	// Use this for initialization
	void Start () {
		topLid = GameObject.Find ("EyeLid_Top");
		botLid = GameObject.Find ("EyeLid_Bottom");
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 5f;
			blink = true;
		}
		if(blink == true){

			topLid.GetComponent<Animation>().Play("BlinkTop");
			botLid.GetComponent<Animation>().Play ("BlinkBottom");
			blink = false;

		}
	
	}

	public void OnGUI(){ 
		int time = (int)timer + 1;
		GUI.Box (new Rect (5, 35, 55,25), "Blinking: ");
		GUI.Box (new Rect (65, 35, 55,25),"" +time);
	}

	/*function OnGUI()
	{
		GUI.Box(Rect(5, 5, 55, 25), "Sanity");
		GUI.Box(Rect(65, 5, 55, 25), currentSanity.ToString("0") + "/" + maxSanity);
	}*/


}
