using UnityEngine;
using System.Collections;

public class BugSpawn : MonoBehaviour {


	public GameObject bugPrefab;

	private IEnumerator coroutine;

	public GameObject displayBox;

	private bool SpanIsRunning = false;
	// Use this for initialization
	void Start () {

		coroutine = WaitAndSpawnBug(5.0f);
		StartCoroutine(coroutine);

		if(displayBox != null)
		{
			displayBox.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(SpanIsRunning == false)
		{
			coroutine = WaitAndSpawnBug(Random.Range(1.0f, 3.0f));
			StartCoroutine(coroutine);
		}


	
	}

	private IEnumerator WaitAndSpawnBug(float waitTime) {
		SpanIsRunning = true;
		//Debug.Log("Wait HERE: " + waitTime);
		yield return new WaitForSeconds(waitTime);
		Instantiate(bugPrefab, transform.position, transform.rotation);
		//Debug.Log("SPAWN BUG");
		SpanIsRunning = false;

	}
}
