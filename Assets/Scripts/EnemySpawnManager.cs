using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemySpawnManager : MonoBehaviour {

	public Transform playerPosition;
	public GameObject[] enemies;                // The enemy prefabs to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	public bool canSpawn = false;
	int count = 1;
	public int shipCount = 0;
	public int wavecount = 1;
	public Text wavetext;
	public float delay1 = 5;
	public float next = 0;

	// Use this for initialization
	void Start () {
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		//Delay();
		//Text wavetext = GameObject.FindGameObjectWithTag("WaveText").GetComponent<Text>();
		//wavetext.enabled = true;
		
		
			
			
				InvokeRepeating ("Spawn", spawnTime, spawnTime);
				//StartCoroutine("Spawn");
				/*while (wavecount < 3)
					{ while(shipCount <3)
						{
							Debug.Log("HII");
							StartCoroutine(Spawn());
							Debug.Log("HhhhII");
							shipCount++;
						}
					wavecount++;
					shipCount = 0;
				}*
			
			
		
		/*if (wavecount > 3)
		{	
			Text wavetext = GameObject.FindGameObjectWithTag("WaveText").GetComponent<Text>();
			wavetext.text = "GAME OVER! YOU SAVED R2D2. ANOTHER VICTORY FOR THE REBELS!";
			wavetext.enabled = true;
		}*/
		//Delay();
	}
	

	void Delay ()
     {
        //wavetext.enabled = true;
        //yield return new WaitForSeconds (3);
        Text wavetext = GameObject.FindGameObjectWithTag("WaveText").GetComponent<Text>();
        //wavetext.text = "I have a bad feeling about this...";
        wavetext.enabled = false;
     }
	

	IEnumerator newWave(){
		yield return new WaitForSeconds(10);
		StopCoroutine("newWave");
	}



	void Spawn ()
	{	
		//Debug.Log("0000");
		//while(wavecount < 3)
		//{	//Debug.Log("yo");
		//{
		//while(shipCount < 3)
		//{
		//Debug.Log("Check 1");
		if (Time.time > next){
		if( shipCount < wavecount*3 ){
		Debug.Log("1111");
		if(count == 1  && canSpawn ) {
			Debug.Log("Check 12");
			Text wavetext = GameObject.FindGameObjectWithTag("WaveText").GetComponent<Text>();
			wavetext.text = "Wave " + wavecount;
			wavetext.enabled = true;
			Invoke("Delay", 2);
			count = 0;
			//StartCoroutine(Delay());
			//System.Threading.Thread.Sleep(3000);
			//wavetext.enabled = false;
		}	
		if (canSpawn) {
			//Debug.Log("Check 13");
			//Debug.Log("012233");
			GameObject enemyShip;
			shipCount ++;
			if(shipCount >= wavecount*3)
			{
				wavecount++;
				count = 1;
				next = Time.time + delay1;
				//StopCoroutine("Spawn");
				//yield return new WaitForSeconds(3);
			}
			// Find a random index between zero and one less than the number of spawn points.
			int enemyIndex = Random.Range (0, enemies.Length);
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			enemyShip = Instantiate (enemies [enemyIndex], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation) as GameObject;
			enemyShip.transform.rotation = Quaternion.Euler (0.0f, 90.0f, 0.0f);

			// Change names to be more readable

			if (enemyShip.name == "star-wars-vader-tie-fighter(Clone)") {
				enemyShip.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
				enemyShip.name = "VaderShip";
			}

			else if (enemyShip.name == "sithcraft(Clone)") {
				enemyShip.transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
				enemyShip.name = "SithCraft";
			}

			enemyShip.tag = "EnemyShip";

			enemyShip.AddComponent<BoxCollider> ();
			BoxCollider collider = enemyShip.GetComponent<Collider> () as BoxCollider;
			collider.size = new Vector3 (20.0f, 20.0f, 20.0f);

			enemyShip.AddComponent<Rigidbody> ();
			Rigidbody body = enemyShip.GetComponent<Rigidbody> ();
			body.useGravity = false;

			enemyShip.AddComponent<EnemyAI> ();
			EnemyAI ai = enemyShip.GetComponent<EnemyAI> ();
			ai.playerPosition = playerPosition;
			
	}
}
	/*			}
			shipCount++;
			}
			wavecount++;
			shipCount = 0;
		}
	*/	
	//yield return new WaitForSeconds (1);	
	}
//wavecount++ ;
//Debug.Log(wavecount);
//yield return new WaitForSeconds(0);
}
}

