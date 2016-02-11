using UnityEngine;
using System.Collections;

public class EnemySpawnManager : MonoBehaviour {

	public Transform playerPosition;
	public GameObject[] enemies;                // The enemy prefabs to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	public bool canSpawn = false;

	// Use this for initialization
	void Start () {
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn ()
	{
		if (canSpawn) {
			GameObject enemyShip;

			// Find a random index between zero and one less than the number of spawn points.
			int enemyIndex = Random.Range (0, enemies.Length);
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			enemyShip = Instantiate (enemies [enemyIndex], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation) as GameObject;
			enemyShip.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			enemyShip.transform.rotation = Quaternion.Euler (0.0f, 90.0f, 0.0f);

			// Change names to be more readable

			if (enemyShip.name == "star-wars-vader-tie-fighter(Clone)") {
				enemyShip.name = "VaderShip";
				enemyShip.tag = "EnemyShip";
			}

			enemyShip.AddComponent<BoxCollider> ();
			BoxCollider collider = enemyShip.GetComponent<Collider> () as BoxCollider;
			collider.size = new Vector3 (20.0f, 20.0f, 20.0f);

			enemyShip.AddComponent<Rigidbody> ();
			Rigidbody body = enemyShip.GetComponent<Rigidbody> ();
			body.useGravity = false;

			enemyShip.AddComponent<EnemyAI> ();
			EnemyAI ai = enemyShip.GetComponent<EnemyAI> ();
			ai.playerPosition = playerPosition;
		}
	}
}
