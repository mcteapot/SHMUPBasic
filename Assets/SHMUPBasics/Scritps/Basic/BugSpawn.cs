using UnityEngine;
using System.Collections;

public class BugSpawn : MonoBehaviour {

	public GameObject bugPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate(bugPrefab, transform.position, transform.rotation);
	
	}
}
