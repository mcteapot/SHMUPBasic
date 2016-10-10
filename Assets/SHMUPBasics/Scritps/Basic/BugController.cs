using UnityEngine;
using System.Collections;

public class BugController : MonoBehaviour {

	public float bugSpeed = 1.0f;

	public GameSystem gameSystem;

	public GameObject somePrefab;

	// Use this for initialization
	void Start () {
		//gameSystem = new GameSystem();
		GameObject tempGameObject = GameObject.Find("GameSystemsManager");
		gameSystem = tempGameObject.GetComponent( typeof(GameSystem) ) as GameSystem;
		//RandomHSB randomHSB = gameSystem.gameObject.GetComponent<RandomHSB>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * bugSpeed);
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);

		//Debug.Log("TRIGGER WORKING");
		if(other.gameObject.tag == "Bullet")
		{
			//Debug.Log("BUG HIT");
			if(gameSystem != null)
			{
					gameSystem.HitByBullet();
			}
			else
			{
				Debug.LogWarning("gameSystem is not set");
			}

			Destroy(gameObject);			
		}


	}
}
