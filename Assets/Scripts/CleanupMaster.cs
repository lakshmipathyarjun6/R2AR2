using UnityEngine;
using System.Collections;

public class CleanupMaster : MonoBehaviour {

	public void cleanUpAll () 
	{
		GameObject[] allVaderShips = GameObject.FindGameObjectsWithTag ("EnemyShip");
		foreach(GameObject ship in allVaderShips) {
			Destroy (ship);
		}

		GameObject[] allFire = GameObject.FindGameObjectsWithTag ("EnemyFire");
		foreach(GameObject fire in allFire) {
			Destroy (fire);
		}
	}

}
