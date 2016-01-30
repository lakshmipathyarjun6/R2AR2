using UnityEngine;
using System.Collections;

public class MoveForwardShip : MonoBehaviour {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {

	}
    void Update() {
		transform.position += transform.forward * speed * Time.deltaTime;
    }
}