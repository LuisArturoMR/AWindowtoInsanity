using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
	
	public GameObject Enemy;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider c){

		if(c.gameObject.tag =="Enemy"){
			Debug.Log ("In!!");
			Enemy.SendMessage ("StopMoving");
		}

		//Enemy.SendMessage ("Loops", true);
	}
	
	void OnTriggerExit(Collider c){
		if(c.gameObject.tag =="Enemy"){
			Debug.Log ("Out!!");
			//Enemy.SendMessage ("Loops", false);
			Enemy.SendMessage ("StartMoving");

		}

	}
}
