using UnityEngine;
using System.Collections;

public class Boy : MonoBehaviour {
	public CharacterController character;
	public AudioClip sound;
	public GameObject mamma;
	float run;
	float distance = 0;
	bool doMove=false;
	
	GameObject player;

	//void playSound(int clip){
		//GetComponent<AudioSource>().clip = audioClip;

	//}
	
	public void StartMoving(){
		GetComponent<AudioSource>().PlayOneShot(sound);
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
			character.Move (transform.TransformDirection (Vector3.forward) * 0.7f);
		}
	}

	void Run(){

		Invoke ("StartMoving", 5f);

	}

	void OnTriggerEnter(Collider c){

		if(c.gameObject.tag == "Player"){

			this.GetComponent<Renderer>().enabled = false;
			mamma.SendMessage("KillHim");
			Invoke ("Killme", 3f);

		}
	}

	void Killme(){
		Destroy (gameObject);
	}

}
