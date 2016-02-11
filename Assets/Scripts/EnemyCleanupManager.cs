using UnityEngine;
using System.Collections;

public class EnemyCleanupManager : MonoBehaviour {
	
	void OnTriggerEnter (Collider col) 
	{

		if (col.gameObject.tag == "EnemyFire") {
			Destroy (col.gameObject);
		} 

		else if (col.gameObject.tag == "EnemyShip") {
			Destroy (col.gameObject);
		}
	}
		
}
