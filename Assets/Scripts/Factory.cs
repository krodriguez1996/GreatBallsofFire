using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

	public Vector3 spawnValues= new Vector3(15,15,15);
	public float startWait;
	public GameObject o;
	public float spawnWait;


	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnWaves());
	}

	IEnumerator SpawnWaves()
	{
		while (true) {
			yield return new WaitForSeconds (startWait);
			Vector3 spawnPosition = new Vector3 (-40, Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));
			Quaternion spawnRotation = Quaternion.identity;
			GameObject n= (GameObject)Instantiate (o, spawnPosition, spawnRotation);
			Observing ball = n.GetComponent<Observing> ();
			float ran = Random.Range (0, 3);
			if (ran == 0) {
				ball.myBehaviour= new MonoAngle();
			} else if (ran == 1) {
				ball.myBehaviour = new ChangeAngle ();
			} else {
				ball.myBehaviour= new JitterAngle();
			}

		}

	}


}
