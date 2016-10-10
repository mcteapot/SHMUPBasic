using UnityEngine;
using System.Collections;

public class GameSystem : MonoBehaviour {

	public int _PlayerScore;
	private int playerScore;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// SCRIPT API //

	public void HitByBullet()
	{
		Debug.Log("I GOT HIT BY A BULLET!");
	}
}
