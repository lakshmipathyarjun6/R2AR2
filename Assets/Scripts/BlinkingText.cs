using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlinkingText : MonoBehaviour {

	public Text theText;
	float speed = 2.0f;

	void Start () {
		theText.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

		Color col = new Color(1.0f, 1.0f, 1.0f, 1.0f);
		col.a = Mathf.Round(Mathf.PingPong(Time.time * speed, 1.0f));
		theText.material.color = col;

	}
}
