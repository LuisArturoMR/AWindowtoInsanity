using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	public CharacterController character;

	float distance = 0;
	bool doMove=false;
	
	GameObject player;

	public void StartMoving(){
		doMove = true;
	}
	
	public void StopMoving(){
		doMove = false;
	}
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		character = this.GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		
		Vector3 pPos = player.transform.position;
		distance = Vector3.Distance (player.transform.position, this.transform.position);
		pPos.y = this.transform.position.y;
		if (doMove == true){
			this.transform.LookAt (pPos);
			character.Move (transform.TransformDirection (Vector3.forward) * .1f);
		}
	}

}