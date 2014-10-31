using UnityEngine;
using System.Collections;

public class Vieja : MonoBehaviour {
	public GameObject player;
	public AudioClip jumpScare;
	public AudioClip scream;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void KillHim(){
		Invoke ("Scare", 1f);
	}

	void Scare(){
		Vector3 position = player.transform.position;
		transform.position = new Vector3(position.x - 1, position.y - 1, position.z - 10);
		GetComponent<AudioSource>().clip = jumpScare;
		GetComponent<AudioSource>().Play();
		//this.GetComponent<Renderer>().enabled = true;
		Invoke ("Load", 3f);
	}

	void Load(){
		//Application.Quit();
	}
}
