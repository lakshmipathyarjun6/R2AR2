using UnityEngine;
using System.Collections;

public class EnemySpawnManager : MonoBehaviour {

	// public PlayerHealth playerHealth;
	public GameObject[] enemies;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.

	// Use this for initialization
	void Start () {
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn ()
	{
		GameObject enemyShip;
		/*// If the player has no health left...
		if(playerHealth.currentHealth <= 0f)
		{
			// ... exit the function.
			return;
		} */

		// Find a random index between zero and one less than the number of spawn points.
		int enemyIndex = Random.Range (0,enemies.Length);
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		enemyShip = Instantiate (enemies[enemyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject;
		enemyShip.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
		enemyShip.transform.rotation = Quaternion.Euler (0.0f, 90.0f, 0.0f);

		enemyShip.AddComponent<BoxCollider> ();
		BoxCollider collider = enemyShip.GetComponent<Collider>() as BoxCollider;
		collider.size = new Vector3 (20.0f, 20.0f, 20.0f);

		enemyShip.AddComponent<Rigidbody> ();
		Rigidbody body = enemyShip.GetComponent<Rigidbody> ();
		body.useGravity = false;

		enemyShip.AddComponent<MoveForwardShip> ();
		enemyShip.AddComponent<FireProjectile> ();

		// Vader's ship only

		/*FireProjectile theProjectile = enemyShip.GetComponent<FireProjectile> ();
		theProjectile.spawnPoint = */
	}
}
