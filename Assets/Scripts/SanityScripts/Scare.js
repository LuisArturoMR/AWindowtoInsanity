#pragma strict

private var sanityScript : InsanityManager;

var scarePerc : float = 60.0;

function Start()
{
	sanityScript = GameObject.Find("Player").GetComponent(InsanityManager);
}

function OnTriggerEnter(Col : Collider)
{
	if(Col.tag == "Player")
	{
		sanityScript.currentSanity -= scarePerc;
	}
}