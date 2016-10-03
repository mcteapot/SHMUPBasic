using UnityEngine;
using System.Collections;

public class BugController : MonoBehaviour {

	public float bugSpeed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * bugSpeed);
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);

		Debug.Log("TRIGGER WORKING");
		Destroy(gameObject);

	}
}
