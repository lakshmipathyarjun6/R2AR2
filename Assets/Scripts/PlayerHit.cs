using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	public PlayerAbuse abuseLevel;
	public Text RudeComments; 

	//public AudioClip playerHitSound;

	/*void Start () {
		gameObject.GetComponent<AudioSource> ().clip = playerHitSound;
	}*/

	void OnTriggerEnter (Collider col) {

		gameObject.GetComponent<AudioSource> ().clip = Resources.Load("Audio/PlayerHit") as AudioClip;

		if (col.gameObject.tag == "EnemyShip") {
			Debug.Log ("Ouch what the hell man?!");
			Destroy (col.gameObject);
		} 

		else if (col.gameObject.tag == "EnemyFire") {
			abuseLevel.TakeAbuse (10.0f);
			RudeComments.text = "WOAAHHHHHH DONT DO THAT SHIT BRUH!!!!";

			gameObject.GetComponent<AudioSource> ().Play ();

			Destroy (col.gameObject);
		} 

		else if (col.gameObject.tag == "MusicSelectionBox") {
			GameObject maintarget = GameObject.FindGameObjectWithTag ("MainTarget");
			maintarget.GetComponent<Vuforia.MainTrackableEventHandler> ().StartGame (col.gameObject.name);
		}
	}
}
