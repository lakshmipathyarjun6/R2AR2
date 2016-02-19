using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyCleanupManager : MonoBehaviour {
	public float points = 0;
	public Text scoreText;
	int check = 0;
	public int destroyed = 0;
	public static EnemyCleanupManager Instance;
	void OnTriggerEnter (Collider col) 
	{	

		Instance = this;
		if (col.gameObject.tag == "EnemyFire") {
			Destroy (col.gameObject);
			destroyed++;
			check = UIController.Instance.state;
			if(check != 1)
			{
				points = points + 1;
			//Text scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
			scoreText.text = "Score: " + points;
			}
		} 

		else if (col.gameObject.tag == "EnemyShip") {
			Destroy (col.gameObject);
			destroyed++;
			check = UIController.Instance.state;
			if(check != 1)
			{
				points = points + 5;
			//Text scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
			scoreText.text = "Score: " + points;
			}
		}
	}
		
}
