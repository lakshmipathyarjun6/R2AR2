using UnityEngine;
using System.Collections;

public class PlayerAbuse : MonoBehaviour {

	public float maxAbuse = 100.0f;
	public float curAbuse = 0.0f;
	public GameObject abuseBar;
	public GameObject smokingEffect;
	public GameObject[] flareEffects;
	public GameObject MainTracker;

	// Use this for initialization
	void Start () {
		curAbuse = maxAbuse; 
		smokingEffect.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		float abuse_calc = curAbuse / maxAbuse;
		SetAbuseBar (abuse_calc);
	}

	public void TakeAbuse (float amount) {
		curAbuse -= amount;

		if (curAbuse <= 60.0f) {
			flareEffects [0].GetComponent<ParticleSystem> ().Play ();
		}

		if (curAbuse <= 40.0f) {
			flareEffects[1].GetComponent<ParticleSystem> ().Play ();
		}

		if (curAbuse <= 20.0f) {
			smokingEffect.GetComponent<ParticleSystem> ().enableEmission = true;
		}

		if (curAbuse <= 0.0f) {
			AudioSource deathScream = gameObject.GetComponent<AudioSource> ();
			deathScream.clip = Resources.Load("Audio/R2Scream") as AudioClip;
			deathScream.Play ();
			curAbuse = 0.0f;

			AudioSource mainAudio = MainTracker.GetComponent<AudioSource> ();
			mainAudio.Stop ();

			mainAudio.clip = MainTracker.GetComponent<Vuforia.MainTrackableEventHandler> ().soundtracks [4];
			mainAudio.Play ();

			GameObject.FindGameObjectWithTag ("MainUI").GetComponent<UIController> ().EnableGameOverState ();

			GameObject mainBoard = GameObject.FindGameObjectWithTag ("MainBoard");
			mainBoard.GetComponent<EnemySpawnManager> ().canSpawn = false;

			MainTracker.GetComponent<CleanupMaster> ().cleanUpAll ();
		}

		else if (curAbuse >= maxAbuse) {
			curAbuse = maxAbuse;
		}
	}

	void SetAbuseBar(float abuse) {
		abuseBar.transform.localScale = new Vector3 (abuse,abuseBar.transform.localScale.y,abuseBar.transform.localScale.z);
	}

}
