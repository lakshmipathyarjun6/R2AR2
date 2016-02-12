using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	public PlayerAbuse abuseLevel;
	public Text RudeComments; 

	public AudioClip playerHitSound;

	void Start () {
		gameObject.AddComponent<AudioSource> ();
		gameObject.GetComponent<AudioSource> ().clip = playerHitSound;
	}

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.name == "VaderShip") {
			Debug.Log ("Ouch what the hell man?!");
			Destroy (col.gameObject);
		}

		else if (col.gameObject.name == "shipFire") {
			//Debug.Log ("WOAAHHHHHH DONT DO THAT SHIT BRUH!!!!");
			abuseLevel.TakeAbuse(4.0f);
			RudeComments.text = "WOAAHHHHHH DONT DO THAT SHIT BRUH!!!!";

			gameObject.GetComponent<AudioSource> ().Play ();

			Destroy (col.gameObject);
		}
	}
}
