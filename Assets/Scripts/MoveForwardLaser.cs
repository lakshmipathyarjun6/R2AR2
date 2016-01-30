using UnityEngine;
using System.Collections;

public class MoveForwardLaser : MonoBehaviour {

	public float speed = 40.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		LineRenderer beam;
		Vector3 offset = new Vector3 (10.0f, 0.0f, 0.0f);

		transform.position += transform.forward * speed * Time.deltaTime;
		beam = gameObject.GetComponent<LineRenderer> ();
		beam.SetPosition (0, transform.position);
		beam.SetPosition (1, transform.position + offset);
	}
}