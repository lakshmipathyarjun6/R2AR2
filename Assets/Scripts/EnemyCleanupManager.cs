using UnityEngine;
using System.Collections;

public class EnemyCleanupManager : MonoBehaviour {
	
	void OnTriggerEnter (Collider col) {
		Destroy (col.gameObject);
	}

}
