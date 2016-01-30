using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour {

	public Transform spawnPoint;
	public GameObject dummy;
	public Material lasermaterial;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("space")) {
			GameObject laser;
			LineRenderer beam;
			Vector3 offset = new Vector3 (10.0f, 0.0f, 0.0f);

			laser = Instantiate (dummy, spawnPoint.position, spawnPoint.rotation) as GameObject;
			beam = laser.AddComponent<LineRenderer> ();
			beam.SetPosition (0, laser.transform.position);
			beam.SetPosition (1, laser.transform.position + offset);
			beam.material = lasermaterial;
			beam.SetWidth (0.5f, 0.5f);
			laser.AddComponent<MoveForwardLaser>();
		}

	}
} 
