﻿using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform playerPosition;
	public float spawnTime = 5f;
	public bool canAttackPlayer = false;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<MoveForwardShip> ();
		gameObject.AddComponent<FireProjectile> ();

		FireProjectile projectileParameters = gameObject.GetComponent<FireProjectile> ();

		if (gameObject.name == "VaderShip") {
			projectileParameters.spawnPoint = gameObject.transform.FindChild ("group").transform.FindChild ("EnginGlo_gunred");
			projectileParameters.lasermaterial =  Resources.Load("Materials/shot_mat") as Material;
		}

		else if (gameObject.name == "SithCraft") {
			projectileParameters.spawnPoint = gameObject.transform.FindChild ("sit").transform.FindChild ("si1").transform.FindChild("laserside");
			projectileParameters.lasermaterial =  Resources.Load("Materials/shot_mat") as Material;
		}

		projectileParameters.playerPosition = playerPosition;

		InvokeRepeating ("Attack", spawnTime, spawnTime);
	}

	void Attack () {
	
		//if (canAttackPlayer) {
			FireProjectile projectile = gameObject.GetComponent<FireProjectile> ();
			projectile.Fire ();
		//}

	}
}
