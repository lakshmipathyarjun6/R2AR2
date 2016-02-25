using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyCleanupManager : MonoBehaviour {
	public Canvas uicanvas;

	int check = 0;
	public int destroyed = 0;
	public static EnemyCleanupManager Instance;
	void OnTriggerEnter (Collider col) 
	{	

		Instance = this;
		if (col.gameObject.tag == "EnemyFire") {
			Destroy (col.gameObject);
			//destroyed++;
			check = UIController.Instance.state;
			if(check != 1)
			{
				uicanvas.GetComponent<UIController> ().updateScore (1);
			}
		} 

		else if (col.gameObject.tag == "EnemyShip") {
			Destroy (col.gameObject);
			destroyed++;
			check = UIController.Instance.state;
			if(check != 1)
			{
				uicanvas.GetComponent<UIController> ().updateScore (5);
			}
		}
	}
		
}
