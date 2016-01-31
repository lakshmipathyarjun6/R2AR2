using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	public PlayerAbuse abuseLevel;
	public Text RudeComments; 

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.name == "star-wars-vader-tie-fighter(Clone)") {
			Debug.Log ("Ouch what the hell man?!");
			Destroy (col.gameObject);
		}

		else if (col.gameObject.name == "shipFire") {
			//Debug.Log ("WOAAHHHHHH DONT DO THAT SHIT BRUH!!!!");
			abuseLevel.TakeAbuse(4.0f);
			RudeComments.text = "WOAAHHHHHH DONT DO THAT SHIT BRUH!!!!";
			Destroy (col.gameObject);
		}
	}
}
