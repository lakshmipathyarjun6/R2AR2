using UnityEngine;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	void OnTriggerEnter (Collider col) {
		Debug.Log ("Ouch what the hell man?!");

		if (col.gameObject.name == "star-wars-vader-tie-fighter(Clone)") {
			Destroy (col.gameObject);
		}
	}
}
