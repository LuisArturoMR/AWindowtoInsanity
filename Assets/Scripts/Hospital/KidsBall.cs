using UnityEngine;
using System.Collections;

public class KidsBall : MonoBehaviour {
	public GameObject ball;
	private bool gravity = false;
	public GameObject laughBox;

	public AudioClip laugh;

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player"){
			gravity = true;
			ball.gameObject.GetComponent<Rigidbody>().AddForce (new Vector3(0,0,-10),ForceMode.Impulse);
			laughBox.GetComponent<AudioSource>().PlayOneShot(laugh);
		}
	}

	// Update is called once per frame
	void Update () {
		ball.gameObject.GetComponent<Rigidbody> ().useGravity = gravity;
	}
}
