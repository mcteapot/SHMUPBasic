using UnityEngine;
using System.Collections;

public class ObjectHit : MonoBehaviour {


	public GameSystem gameSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {

		if(collision.gameObject.tag == "Bullet")
		{

			//GameSystem.HitByBullet();
			Debug.Log("BUG HIT");
			//if(gameSystem != null)
			//{
				gameSystem.HitByBullet();
			//}
		
		}
		
	}
}
