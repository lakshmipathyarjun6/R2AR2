using UnityEngine;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.name == "star-wars-vader-tie-fighter(Clone)") {
			Debug.Log ("Ouch what the hell man?!");
			Destroy (col.gameObject);
		}

		else if (col.gameObject.name == "shipFire") {
			Debug.Log ("WOAAHHHHHH DONT DO THAT SHIT BRUH!!!!");
			Destroy (col.gameObject);
		}
	}
}
