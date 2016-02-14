using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

	int state = 0;

	// Use this for initialization
	void Start () {
		/*GameObject[] elements = GameObject.FindGameObjectsWithTag ("MainGameUIElement");
		Debug.Log (elements.Length);
		foreach(GameObject element in elements) {
			if (element.GetComponent<Image> ()) {
				element.GetComponent<Image> ().enabled = false;
			}
			else if(element.GetComponent<Text> ()) {
				element.GetComponent<Text> ().enabled = false;
			}
		}*/
	}

	public void ChangeState(int forwardOrBackward) {

		state += forwardOrBackward;
		if (state < 0)
			state = 0;
	
		Debug.Log (state);

		switch (state) {
			case 1:
				EnableR2SearchingState ();
				break;
			case 2:
				EnableMainGameState ();
				break;
			default:
				EnableDefaultState ();
				break;
		}

	}

	void EnableDefaultState() {
		GameObject[] elements = GameObject.FindGameObjectsWithTag ("MainGameUIElement");
		foreach(GameObject element in elements) {
			if (element.GetComponent<Image> ()) {
				element.GetComponent<Image> ().enabled = false;
			}
			else if(element.GetComponent<Text> ()) {
				element.GetComponent<Text> ().enabled = false;
			}
		}

		Text centralText = GameObject.FindGameObjectWithTag("CentralText").GetComponent<Text>();
		centralText.enabled = true;
		centralText.text = "Searching for Game Board";
	}

	void EnableR2SearchingState() {
		GameObject[] elements = GameObject.FindGameObjectsWithTag ("MainGameUIElement");
		foreach(GameObject element in elements) {
			if (element.GetComponent<Image> ()) {
				element.GetComponent<Image> ().enabled = false;
			}
			else if(element.GetComponent<Text> ()) {
				element.GetComponent<Text> ().enabled = false;
			}
		}

		Text centralText = GameObject.FindGameObjectWithTag("CentralText").GetComponent<Text>();
		centralText.enabled = true;
		centralText.text = "Searching for R2D2";
	}

	/*public void DisableR2Searching() {
		Text centralText = GameObject.FindGameObjectWithTag("CentralText").GetComponent<Text>();
		centralText.text = "Searching for Game Board";
	}*/

	void EnableMainGameState() {
		GameObject[] elements = GameObject.FindGameObjectsWithTag ("MainGameUIElement");
		foreach(GameObject element in elements) {
			if (element.GetComponent<Image> ()) {
				element.GetComponent<Image> ().enabled = true;
			}
			else if(element.GetComponent<Text> ()) {
				element.GetComponent<Text> ().enabled = true;
			}
		}

		Text centralText = GameObject.FindGameObjectWithTag("CentralText").GetComponent<Text>();
		centralText.enabled = false;
	}

	/*public void DisableMainGame() {
		GameObject[] elements = GameObject.FindGameObjectsWithTag ("MainGameUIElement");
		Debug.Log (elements.Length);
		foreach(GameObject element in elements) {
			if (element.GetComponent<Image> ()) {
				element.GetComponent<Image> ().enabled = false;
			}
			else if(element.GetComponent<Text> ()) {
				element.GetComponent<Text> ().enabled = false;
			}
		}

		Text centralText = GameObject.FindGameObjectWithTag("CentralText").GetComponent<Text>();
		centralText.enabled = true;
		centralText.text = "Searching for R2D2";
	}*/

}
