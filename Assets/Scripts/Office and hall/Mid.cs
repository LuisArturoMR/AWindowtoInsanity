using UnityEngine;
using System.Collections;

public class Mid : MonoBehaviour {

	public GameObject boy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag == "Player"){
			boy.GetComponent<Renderer>().enabled = true;
			boy.SendMessage("Run");
		}
	}
}

