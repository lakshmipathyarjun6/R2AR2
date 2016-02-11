using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour {

	public Transform spawnPoint;
	public Material lasermaterial;
	public Transform playerPosition;

	// Use this for initialization
	void Start () {

	}

	public void Fire () {
		
		LineRenderer beam;
		GameObject laser = new GameObject ();
		laser.transform.position = spawnPoint.position;
		laser.transform.LookAt (playerPosition);
		laser.name = "VaderShipFire";
		laser.tag = "EnemyFire";

		laser.AddComponent<BoxCollider> ();
		BoxCollider collider = laser.GetComponent<Collider>() as BoxCollider;
		collider.center = new Vector3(0.0f,0.0f,5.0f);
		collider.size = new Vector3 (0.3f, 0.5f, 10.0f);
		collider.isTrigger = true;

		laser.AddComponent<Rigidbody> ();
		Rigidbody body = laser.GetComponent<Rigidbody> ();
		body.useGravity = false;

		beam = laser.AddComponent<LineRenderer> ();
		beam.material = lasermaterial;
		beam.SetWidth (0.5f, 0.5f);
		laser.AddComponent<MoveForwardLaser>();

		laser.AddComponent<AudioSource> ();
		AudioSource fire = laser.GetComponent<AudioSource> ();
		fire.clip = Resources.Load("Audio/VaderTieFire") as AudioClip;
		fire.Play ();

	}
} 
