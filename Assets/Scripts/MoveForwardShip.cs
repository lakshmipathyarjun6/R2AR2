using UnityEngine;
using System.Collections;

public class MoveForwardShip : MonoBehaviour {

	public float speed = 5.0f;
	int check = 0;
	// Use this for initialization
	void Start () {

	}
    void Update() {
		check = UIController.Instance.state;
		if(check != 1)
		transform.position += transform.forward * speed * Time.deltaTime;
    }
}