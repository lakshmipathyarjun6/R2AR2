﻿using UnityEngine;
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
		{
			if(EnemySpawnManager.Instance != null)
				speed = 10 / EnemySpawnManager.Instance.wavecount;
		transform.position += transform.forward * speed * Time.deltaTime;
    	}
    }
}