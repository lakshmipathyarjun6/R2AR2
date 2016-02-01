using UnityEngine;
using System.Collections;

public class EnemyCleanupManager : MonoBehaviour {
	
	void OnTriggerEnter (Collider col) {

		if (col.gameObject.name == "shipFire") {
			Destroy (col.gameObject);
		} 

		else if (col.gameObject.name == "VaderShip") {
			Destroy (col.gameObject);
		}
	}

}
