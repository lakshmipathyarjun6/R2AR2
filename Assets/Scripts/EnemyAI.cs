using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform playerPosition;
	public float spawnTime = 5f;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<MoveForwardShip> ();
		gameObject.AddComponent<FireProjectile> ();

		FireProjectile projectileParameters = gameObject.GetComponent<FireProjectile> ();

		if (gameObject.name == "VaderShip") {
			projectileParameters.spawnPoint = gameObject.transform.FindChild ("group").transform.FindChild ("EnginGlo_gunred");
			projectileParameters.lasermaterial =  Resources.Load("Materials/gunred") as Material;
		}

		projectileParameters.playerPosition = playerPosition;

		InvokeRepeating ("Attack", spawnTime, spawnTime);
	}
	
	/* // Update is called once per frame
	void Update () {
	
	} */

	void Attack () {
	
		FireProjectile projectile = gameObject.GetComponent<FireProjectile> ();
		projectile.Fire ();

	}
}
